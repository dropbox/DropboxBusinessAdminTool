namespace DfBAdminToolkit.Presenter {

    using Common.Services;
    using Common.Utils;
    using CsvHelper;
    using CsvHelper.Configuration;
    using Model;
    using View;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading;

    public class TeamAuditingPresenter
        : PresenterBase, ITeamAuditingPresenter {

        public TeamAuditingPresenter(ITeamAuditingModel model, ITeamAuditingView view)
            : base(model, view)
        {
        }

        protected override void Initialize()
        {
            ITeamAuditingView view = base._view as ITeamAuditingView;
            ITeamAuditingModel model = base._model as ITeamAuditingModel;
            PresenterBase.SetViewPropertiesFromModel<ITeamAuditingView, ITeamAuditingModel>(
                ref view, model
            );

            SyncContext.Post(delegate 
            {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents()
        {
            if (!IsViewEventsWired) {
                ITeamAuditingView view = base._view as ITeamAuditingView;
                view.DataChanged += DataChanged;
                view.CommandLoadTeamEvents += OnCommandLoadEvents;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents()
        {
            if (IsViewEventsWired)
            {
                ITeamAuditingView view = base._view as ITeamAuditingView;
                view.DataChanged -= DataChanged;
                view.CommandLoadTeamEvents -= OnCommandLoadEvents;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp()
        {
        }

        public void UpdateSettings()
        {
            DataChanged(this, new EventArgs());
        }

        #region REST Service

        private void GetEvents(ITeamAuditingModel model, ITeamAuditingView view, IMainPresenter presenter)
        {
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.GetEventsUrl = ApplicationResource.ActionGetEvents;
            service.UserAgentVersion = ApplicationResource.UserAgent;

            IDataResponse response = service.GetEvents(new MemberData()
            {
                SearchLimit = ApplicationResource.SearchDefaultLimit
            }, ApplicationResource.DefaultAccessToken, view.StartTime, view.EndTime);

            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.UpdateProgressInfo("Gathering events...");
                }, null);
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (response.Data != null)
                {
                    string data = response.Data.ToString();
                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                    int resultCount = jsonData["events"].Count;
                    for (int i = 0; i < resultCount; i++)
                    {
                        dynamic events = jsonData["events"][i];
                        dynamic timestampObj = events["timestamp"];

                        //go through event categories and compare to what we are looking for
                        int eventCategoryCount = events["event_categories"].Count;      
                        for (int i2 = 0; i2 < eventCategoryCount; i2++)
                        {
                            dynamic eventCategories = events["event_categories"][i2];
                            dynamic eventCategoryObj = eventCategories[".tag"];
                            string eventCategory = eventCategoryObj.Value as string;
                        }

                        dynamic actorType = events["actor"][".tag"];
                        string actorTypeString = actorType.Value as string;
                        dynamic emailObj = null;

                        if (actorTypeString == "user")
                        {
                            emailObj = events["actor"]["user"]["email"];
                        }
                        if (actorTypeString == "admin")
                        {
                            emailObj = events["actor"]["app"]["display_name"];
                        }
                        if (actorTypeString == "app")
                        {
                            emailObj = events["actor"]["app"]["display_name"];
                        }
                        if (actorTypeString == "reseller")
                        {
                            emailObj = events["actor"]["reseller"]["reseller_name"];
                        }
                        if (actorTypeString == "Dropbox")
                        {
                            emailObj = "Dropbox";
                        }
                        //dynamic contextObj = events["context"];
                        dynamic eventTypeObj = events["event_type"][".tag"];
                        dynamic detailsTypeObj = events["details"];
                        dynamic originObj = events["origin"]["access_method"][".tag"];
                        dynamic ipAddressObj = events["origin"]["geo_location"]["ip_address"];
                        dynamic cityObj = events["origin"]["geo_location"]["city"];
                        dynamic regionObj = events["origin"]["geo_location"]["region"];
                        dynamic countryObj = events["origin"]["geo_location"]["country"];
                        //dynamic participantsObj = events["participants"];
                        //dynamic assetsObj = events["assets"];

                        //render to use
                        DateTime timestamp = DateTime.MinValue;
                        if (timestampObj != null)
                        {
                            timestamp = timestampObj;
                        }
                        string email = emailObj;
                        //string context = contextObj.Value as string;
                        string context = string.Empty;
                        string eventType = eventTypeObj.Value as string;
                        string details = detailsTypeObj.Value as string;
                        string origin = originObj.Value as string;
                        string ipAddress = ipAddressObj.Value as string;
                        string city = cityObj.Value as string;
                        string region = regionObj.Value as string;
                        string country = countryObj.Value as string;
                        //string participants = participantsObj.Value as string;
                        //string assets = assetsObj.Value as string;
                        string participants = string.Empty;
                        string assets = string.Empty;

                        // update model
                        TeamAuditingListViewItemModel lvItem = new TeamAuditingListViewItemModel()
                        {
                            Timestamp = timestamp,
                            ActorType = actorTypeString,
                            Email = email, //actor
                            Context = context,
                            EventType = eventType,
                            Details = details,
                            Origin = origin,
                            IpAddress = ipAddress,
                            City = city,
                            Region = region,
                            Country = country,
                            Participants = participants,
                            Assets = assets,
                            IsChecked = true
                        };
                        model.TeamAuditing.Add(lvItem);
                    }
                    // collect more.
                    bool hasMore = jsonData["has_more"];
                    string cursor = jsonData["cursor"];

                    while (hasMore)
                    {
                        service.GetEventsUrl = ApplicationResource.ActionGetEventsContinuation;
                        IDataResponse responseCont = service.GetEvents(new MemberData()
                        {
                            Cursor = cursor
                        }, ApplicationResource.DefaultAccessToken, view.StartTime, view.EndTime);

                        string dataCont = responseCont.Data.ToString();
                        dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                        int resultContCount = jsonDataCont["events"].Count;
                        for (int i = 0; i < resultContCount; i++)
                        {
                            dynamic events = jsonDataCont["events"][i];
                            dynamic timestampObj = events["timestamp"];

                            //go through event categories and compare to what we are looking for
                            int eventCategoryCount = events["event_categories"].Count;
                            for (int i2 = 0; i2 < eventCategoryCount; i2++)
                            {
                                dynamic eventCategories = events["event_categories"][i2];
                                dynamic eventCategoryObj = eventCategories[".tag"];
                                string eventCategory = eventCategoryObj.Value as string;
                            }

                            dynamic actorType = events["actor"][".tag"];
                            string actorTypeString = actorType.Value as string;
                            dynamic emailObj = null;

                            if (actorTypeString == "user")
                            {
                                emailObj = events["actor"]["user"]["email"];
                            }
                            if (actorTypeString == "admin")
                            {
                                emailObj = events["actor"]["app"]["display_name"];
                            }
                            if (actorTypeString == "app")
                            {
                                emailObj = events["actor"]["app"]["display_name"];
                            }
                            if (actorTypeString == "reseller")
                            {
                                emailObj = events["actor"]["reseller"]["reseller_name"];
                            }
                            if (actorTypeString == "Dropbox")
                            {
                                emailObj = "Dropbox";
                            }
                            //dynamic contextObj = events["context"];
                            dynamic eventTypeObj = events["event_type"][".tag"];
                            dynamic detailsTypeObj = events["details"];
                            dynamic originObj = events["origin"]["access_method"][".tag"];
                            dynamic ipAddressObj = events["origin"]["geo_location"]["ip_address"];
                            dynamic cityObj = events["origin"]["geo_location"]["city"];
                            dynamic regionObj = events["origin"]["geo_location"]["region"];
                            dynamic countryObj = events["origin"]["geo_location"]["country"];
                            //dynamic participantsObj = events["participants"];
                            //dynamic assetsObj = events["assets"];

                            //render to use
                            DateTime timestamp = DateTime.MinValue;
                            if (timestampObj != null)
                            {
                                timestamp = timestampObj;
                            }
                            string email = emailObj;
                            //string context = contextObj.Value as string;
                            string context = string.Empty;
                            string eventType = eventTypeObj.Value as string;
                            string details = detailsTypeObj.Value as string;
                            string origin = originObj.Value as string;
                            string ipAddress = ipAddressObj.Value as string;
                            string city = cityObj.Value as string;
                            string region = regionObj.Value as string;
                            string country = countryObj.Value as string;
                            //string participants = participantsObj.Value as string;
                            //string assets = assetsObj.Value as string;
                            string participants = string.Empty;
                            string assets = string.Empty;

                            // update model
                            TeamAuditingListViewItemModel lvItem = new TeamAuditingListViewItemModel()
                            {
                                Timestamp = timestamp,
                                ActorType = actorTypeString,
                                Email = email, //actor
                                Context = context,
                                EventType = eventType,
                                Details = details,
                                Origin = origin,
                                IpAddress = ipAddress,
                                City = city,
                                Region = region,
                                Country = country,
                                Participants = participants,
                                Assets = assets,
                                IsChecked = true
                            };
                            model.TeamAuditing.Add(lvItem);
                        }
                    }
                }
            }
        }

        #endregion REST Service

        #region Events

        private void OnCommandLoadEvents(object sender, EventArgs e)
        {
            ITeamAuditingView view = base._view as ITeamAuditingView;
            ITeamAuditingModel model = base._model as ITeamAuditingModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Loading team folders input File...");
                }, null);
            }
            Thread teamfoldersLoad = new Thread(() => {
                if (!string.IsNullOrEmpty(model.AccessToken))
                {
                    this.GetEvents(model, view, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate {
                            // update result and update view.
                            view.RenderTeamAuditingList(model.TeamAuditing);
                            presenter.UpdateProgressInfo("Events loaded.");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            teamfoldersLoad.Start();
        }

        private void DataChanged(object sender, System.EventArgs e) {
            ITeamAuditingView view = base._view as ITeamAuditingView;
            ITeamAuditingModel model = base._model as ITeamAuditingModel;
            PresenterBase.SetModelPropertiesFromView<ITeamAuditingModel, ITeamAuditingView>(
                ref model, view
            );
        }

        #endregion Events
    }
}