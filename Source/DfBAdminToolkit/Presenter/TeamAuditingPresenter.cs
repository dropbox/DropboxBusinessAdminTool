namespace DfBAdminToolkit.Presenter {

    using Common.Services;
    using Common.Utils;
    using CsvHelper;
    using CsvHelper.Configuration;
    using Model;
    using View;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Net;
    using System.Threading;
    using System.Collections.Generic;

    public class TeamAuditingPresenter
        : PresenterBase, ITeamAuditingPresenter {

        public TeamAuditingPresenter(ITeamAuditingModel model, ITeamAuditingView view)
            : base(model, view)
        {
        }

        public int EventCount { get; set; }

        List<MemberListViewItemModel> members;

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
                view.CommandLoadCSV += OnCommandLoadCSV;
                view.CommandExportToCSV += OnCommandExportEvents;
                view.CommandFilterMembers += OnCommandFilterMembers;
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
                view.CommandLoadCSV -= OnCommandLoadCSV;
                view.CommandExportToCSV -= OnCommandExportEvents;
                view.CommandFilterMembers -= OnCommandFilterMembers;
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
            string eventCategory = view.EventCategory;
            EventCount = 0;
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
                        bool inCategories = false;
                        dynamic events = jsonData["events"][i];
                        dynamic timestampObj = events["timestamp"];

                        //go through event categories and compare to combobox filter
                        int eventCategoryCount = events["event_categories"].Count;      
                        for (int i2 = 0; i2 < eventCategoryCount; i2++)
                        {
                            dynamic eventCategories = events["event_categories"][i2];
                            dynamic eventCategoryObj = eventCategories[".tag"];
                            string eventCategoryReturn = eventCategoryObj.Value as string;

                            if (eventCategoryReturn == eventCategory.ToLower())
                            {
                                inCategories = true;
                            }
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
                        dynamic contextTypeObj = events["context"][".tag"];
                        string contextTypeString = contextTypeObj.Value as string;
                        dynamic contextObj = null;
                        string context = string.Empty;

                        if (contextTypeString == "team_member" || contextTypeString == "non_team_member")
                        {
                            contextObj = events["context"]["email"];
                            context = contextObj.Value as string;
                        }
                        if (contextTypeString == "team")
                        {
                            contextObj = "Team";
                            context = contextObj;
                        }
                        dynamic eventTypeObj = events["event_type"][".tag"];
                        dynamic originObj = events["origin"]["access_method"][".tag"];
                        dynamic ipAddressObj = events["origin"]["geo_location"]["ip_address"];
                        dynamic cityObj = events["origin"]["geo_location"]["city"];
                        dynamic regionObj = events["origin"]["geo_location"]["region"];
                        dynamic countryObj = events["origin"]["geo_location"]["country"];

                        string participants = string.Empty;
                        if (events["participants"] != null)
                        {
                            int participantsCount = events["participants"].Count;
                            dynamic participantsCatObj = null;
                            string participantsCategory = string.Empty;
                            dynamic participantsObj = null;
                            
                            if (participantsCount > 0)
                            {
                                participantsCatObj = events["participants"][0][".tag"];
                                participantsCategory = participantsCatObj.Value as string;

                                if (participantsCategory == "user")
                                {
                                    if (events["participants"][0]["user"]["email"] != null)
                                    {
                                        participantsObj = events["participants"][0]["user"]["email"];
                                        participants = participantsObj.Value as string;
                                    }   
                                }
                                if (participantsCategory == "group")
                                {
                                    if (events["participants"][0]["display_name"] != null)
                                    {
                                        participantsObj = events["participants"][0]["display_name"];
                                        participants = participantsObj.Value as string;
                                    }   
                                }
                            }
                        }
                        string assets = string.Empty;
                        if (events["assets"] != null)
                        {
                            int assetsCount = events["assets"].Count;
                            dynamic assetsCatObj = null;
                            string assetsCat = string.Empty;
                            dynamic assetsObj = null;

                            if (assetsCount > 0)
                            {
                                assetsCatObj = events["assets"][0][".tag"];
                                assetsCat = assetsCatObj.Value as string;

                                if (assetsCat == "file" || assetsCat == "folder")
                                {
                                    if (events["assets"][0]["display_name"] != null)
                                    {
                                        assetsObj = events["assets"][0]["display_name"];
                                        assets = assetsObj.Value as string;
                                    }
                                }
                                if (assetsCat == "paper_document")
                                {
                                    if (events["assets"][0]["doc_title"] != null)
                                    {
                                        assetsObj = events["assets"][0]["doc_title"];
                                        assets = assetsObj.Value as string;
                                    }
                                }
                                if (assetsCat == "paper_folder")
                                {
                                    if (events["assets"][0]["folder_name"] != null)
                                    {
                                        assetsObj = events["assets"][0]["folder_name"];
                                        assets = assetsObj.Value as string;
                                    }
                                }
                            }
                        }
                        //render to use
                        DateTime timestamp = DateTime.MinValue;
                        if (timestampObj != null)
                        {
                            timestamp = timestampObj;
                        }
                        string email = emailObj;
                        string eventType = eventTypeObj.Value as string;
                        string origin = originObj.Value as string;
                        string ipAddress = ipAddressObj.Value as string;
                        string city = cityObj.Value as string;
                        string region = regionObj.Value as string;

                        if (region != "Unknown")
                        {
                            region = FileUtil.ConvertStateToAbbreviation(region);
                        }
                        string country = countryObj.Value as string;

                        // update model based on category
                        if (eventCategory == "All Events")
                        {
                            TeamAuditingListViewItemModel lvItem = new TeamAuditingListViewItemModel()
                            {
                                Timestamp = timestamp,
                                ActorType = actorTypeString,
                                Email = email,
                                Context = context, 
                                EventType = eventType,
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
                            EventCount++;
                        }
                        if (eventCategory != "All Events" && inCategories)
                        {
                            TeamAuditingListViewItemModel lvItem = new TeamAuditingListViewItemModel()
                            {
                                Timestamp = timestamp,
                                ActorType = actorTypeString,
                                Email = email,
                                Context = context,
                                EventType = eventType,
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
                            EventCount++;
                        }
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
                            bool inCategories = false;
                            dynamic events = jsonDataCont["events"][i];
                            dynamic timestampObj = events["timestamp"];

                            //go through event categories and compare to combobox filter
                            int eventCategoryCount = events["event_categories"].Count;
                            for (int i2 = 0; i2 < eventCategoryCount; i2++)
                            {
                                dynamic eventCategories = events["event_categories"][i2];
                                dynamic eventCategoryObj = eventCategories[".tag"];
                                string eventCategoryReturn = eventCategoryObj.Value as string;

                                if (eventCategoryReturn == eventCategory.ToLower())
                                {
                                    inCategories = true;
                                }
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
                            dynamic contextTypeObj = events["context"][".tag"];
                            string contextTypeString = contextTypeObj.Value as string;
                            dynamic contextObj = null;
                            string context = string.Empty;

                            if (contextTypeString == "team_member" || contextTypeString == "non_team_member")
                            {
                                contextObj = events["context"]["email"];
                                context = contextObj.Value as string;
                            }
                            if (contextTypeString == "team")
                            {
                                contextObj = "Team";
                                context = contextObj;
                            }
                            dynamic eventTypeObj = events["event_type"][".tag"];
                            dynamic originObj = events["origin"]["access_method"][".tag"];
                            dynamic ipAddressObj = events["origin"]["geo_location"]["ip_address"];
                            dynamic cityObj = events["origin"]["geo_location"]["city"];
                            dynamic regionObj = events["origin"]["geo_location"]["region"];
                            dynamic countryObj = events["origin"]["geo_location"]["country"];

                            string participants = string.Empty;
                            if (events["participants"] != null)
                            {
                                int participantsCount = events["participants"].Count;
                                dynamic participantsCatObj = null;
                                string participantsCategory = string.Empty;
                                dynamic participantsObj = null;

                                if (participantsCount > 0)
                                {
                                    participantsCatObj = events["participants"][0][".tag"];
                                    participantsCategory = participantsCatObj.Value as string;

                                    if (participantsCategory == "user")
                                    {
                                        if (events["participants"][0]["user"]["email"] != null)
                                        {
                                            participantsObj = events["participants"][0]["user"]["email"];
                                            participants = participantsObj.Value as string;
                                        }
                                    }
                                    if (participantsCategory == "group")
                                    {
                                        if (events["participants"][0]["display_name"] != null)
                                        {
                                            participantsObj = events["participants"][0]["display_name"];
                                            participants = participantsObj.Value as string;
                                        }
                                    }
                                }
                            }
                            string assets = string.Empty;
                            if (events["assets"] != null)
                            {
                                int assetsCount = events["assets"].Count;
                                dynamic assetsCatObj = null;
                                string assetsCat = string.Empty;
                                dynamic assetsObj = null;

                                if (assetsCount > 0)
                                {
                                    assetsCatObj = events["assets"][0][".tag"];
                                    assetsCat = assetsCatObj.Value as string;

                                    if (assetsCat == "file" || assetsCat == "folder")
                                    {
                                        if (events["assets"][0]["display_name"] != null)
                                        {
                                            assetsObj = events["assets"][0]["display_name"];
                                            assets = assetsObj.Value as string;
                                        }
                                    }
                                    if (assetsCat == "paper_document")
                                    {
                                        if (events["assets"][0]["doc_title"] != null)
                                        {
                                            assetsObj = events["assets"][0]["doc_title"];
                                            assets = assetsObj.Value as string;
                                        }
                                    }
                                    if (assetsCat == "paper_folder")
                                    {
                                        if (events["assets"][0]["folder_name"] != null)
                                        {
                                            assetsObj = events["assets"][0]["folder_name"];
                                            assets = assetsObj.Value as string;
                                        }
                                    }
                                }
                            }
                            //render to use
                            DateTime timestamp = DateTime.MinValue;
                            if (timestampObj != null)
                            {
                                timestamp = timestampObj;
                            }
                            string email = emailObj;
                            string eventType = eventTypeObj.Value as string;
                            string origin = originObj.Value as string;
                            string ipAddress = ipAddressObj.Value as string;
                            string city = cityObj.Value as string;
                            string region = regionObj.Value as string;

                            if (region != "Unknown")
                            {
                                region = FileUtil.ConvertStateToAbbreviation(region);
                            }
                            string country = countryObj.Value as string;

                            // update model based on category
                            if (eventCategory == "All Events")
                            {
                                TeamAuditingListViewItemModel lvItem = new TeamAuditingListViewItemModel()
                                {
                                    Timestamp = timestamp,
                                    ActorType = actorTypeString,
                                    Email = email,
                                    Context = context,
                                    EventType = eventType,
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
                                EventCount++;
                            }
                            if (eventCategory != "All Events" && inCategories)
                            {
                                TeamAuditingListViewItemModel lvItem = new TeamAuditingListViewItemModel()
                                {
                                    Timestamp = timestamp,
                                    ActorType = actorTypeString,
                                    Email = email,
                                    Context = context,
                                    EventType = eventType,
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
                                EventCount++;
                            }
                        }
                    }
                }
            }
        }

        public List<MemberListViewItemModel> LoadMemberInputFile(List<MemberListViewItemModel> members, ITeamAuditingView view, ITeamAuditingModel model, IMainPresenter presenter)
        {
            try
            {
                FileInfo fInfo = new FileInfo(view.TeamAuditingInputFilePath);
                if (fInfo.Exists)
                {
                    // try load.
                    CsvConfiguration config = new CsvConfiguration()
                    {
                        HasHeaderRecord = false
                    };
                    using (CsvReader reader = new CsvReader(new StreamReader(fInfo.FullName), config))
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                MemberListViewItemModel lvItem = new MemberListViewItemModel()
                                {
                                    Email = reader.GetField<string>(0)
                                };
                                members.Add(lvItem);
                            }
                            catch
                            {
                                throw new InvalidDataException(ErrorMessages.INVALID_CSV_DATA);
                            }
                        }
                    }
                }
                else
                {
                    throw new InvalidDataException(ErrorMessages.MISSING_CSV_FILE);
                }
            }
            catch (Exception e)
            {
                SyncContext.Post(delegate 
                {
                    presenter.ShowErrorMessage(e.Message, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("Error loading CSV file.");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return members;
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
                SyncContext.Post(delegate 
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Gathering events...");
                }, null);
            }
            Thread teameventsLoad = new Thread(() => {
                if (!string.IsNullOrEmpty(model.AccessToken))
                {
                    model.TeamAuditing.Clear();
                    this.GetEvents(model, view, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            // update result and update view.
                            view.RenderTeamAuditingList(model.TeamAuditing);
                            presenter.UpdateProgressInfo("Events loaded [" + EventCount.ToString() + "]");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            teameventsLoad.Start();
        }

        private void OnCommandLoadCSV(object sender, EventArgs e)
        {
            ITeamAuditingView view = base._view as ITeamAuditingView;
            ITeamAuditingModel model = base._model as ITeamAuditingModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null)
            {
                SyncContext.Post(delegate 
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Loading members input file to list...");
                }, null);
            }
            Thread groupsLoad = new Thread(() => {
                if (!string.IsNullOrEmpty(model.AccessToken))
                {
                    members = new List<MemberListViewItemModel>();
                    members = this.LoadMemberInputFile(members, view, model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            presenter.UpdateProgressInfo("Members CSV file loaded. Press Filter to filter events.");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            groupsLoad.Start();
        }

        private void OnCommandFilterMembers(object sender, EventArgs e)
        {
            ITeamAuditingView view = base._view as ITeamAuditingView;
            ITeamAuditingModel model = base._model as ITeamAuditingModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null)
            {
                SyncContext.Post(delegate 
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Filtering listview based on members...");
                }, null);
            }
            Thread filtermembers = new Thread(() => {
                if (!string.IsNullOrEmpty(model.AccessToken))
                {
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            view.RenderTeamAudingFilteredMemberList(members, model.TeamAuditing);
                            presenter.UpdateProgressInfo("Filtering complete.");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            filtermembers.Start();
        }

        private void DataChanged(object sender, System.EventArgs e)
        {
            ITeamAuditingView view = base._view as ITeamAuditingView;
            ITeamAuditingModel model = base._model as ITeamAuditingModel;
            PresenterBase.SetModelPropertiesFromView<ITeamAuditingModel, ITeamAuditingView>(
                ref model, view
            );
        }

        private void OnCommandExportEvents(object sender, System.EventArgs e)
        {
            ITeamAuditingView view = base._view as ITeamAuditingView;
            ITeamAuditingModel model = base._model as ITeamAuditingModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null)
            {
                SyncContext.Post(delegate 
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }
            Thread exporteventstocsv = new Thread(() => {
                if (string.IsNullOrEmpty(model.AccessToken))
                {
                    SyncContext.Post(delegate 
                    {
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("");
                    }, null);
                }
                else
                {
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            PresenterBase.SetViewPropertiesFromModel<ITeamAuditingView, ITeamAuditingModel>(
                                ref view, model
                            );
                            string sPath = string.Empty;

                            if (model.TeamAuditing.Count > 0)
                            {
                                //create CSV file in My Documents folder
                                sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TeamAuditingEventsExport.csv";
                                CsvConfiguration config = new CsvConfiguration()
                                {
                                    HasHeaderRecord = true,
                                    Delimiter = ",",
                                    Encoding = System.Text.Encoding.UTF8
                                };
                                config.RegisterClassMap(new TeamAuditingHeaderMap());
                                int total = model.TeamAuditing.Count;
                                using (CsvWriter writer = new CsvWriter(new StreamWriter(sPath), config))
                                {
                                    writer.WriteHeader<TeamAuditingHeaderRecord>();
                                    int count = 0;
                                    foreach (var item in model.TeamAuditing)
                                    {
                                        writer.WriteField<string>(item.Timestamp.ToString());
                                        writer.WriteField<string>(item.ActorType);
                                        writer.WriteField<string>(item.Email);
                                        writer.WriteField<string>(item.Context);
                                        writer.WriteField<string>(item.EventType);
                                        writer.WriteField<string>(item.Origin);
                                        writer.WriteField<string>(item.IpAddress);
                                        writer.WriteField<string>(item.City);
                                        writer.WriteField<string>(item.Region);
                                        writer.WriteField<string>(item.Country);
                                        writer.WriteField<string>(item.Participants);
                                        writer.WriteField<string>(item.Assets);
                                        count++;
                                        if (SyncContext != null)
                                        {
                                            SyncContext.Post(delegate
                                            {
                                                presenter.UpdateProgressInfo(string.Format("Writing Record: {0}/{1}", (count), total));
                                            }, null);
                                        }
                                        writer.NextRecord();
                                    }
                                }
                                if (SyncContext != null)
                                {
                                    SyncContext.Post(delegate
                                    {
                                        presenter.UpdateProgressInfo("Completed. Exported file located at " + sPath);
                                    }, null);
                                }
                            }
                            if (model.TeamAuditing.Count == 0)
                            {
                                presenter.UpdateProgressInfo("No events were chosen to export.");
                            }
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            exporteventstocsv.Start();
        }

        #endregion Events
    }
}