namespace DfBAdminToolkit.Presenter {

    using DfBAdminToolkit.Common.Services;
    using DfBAdminToolkit.Common.Utils;
    using DfBAdminToolkit.Model;
    using DfBAdminToolkit.View;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class TextSearchPresenter
        : PresenterBase, ITextSearchPresenter {

        public TextSearchPresenter(ITextSearchModel model, ITextSearchView view)
            : base(model, view) {
        }

        protected override void Initialize() {
            // read data from model
            ITextSearchView view = base._view as ITextSearchView;
            ITextSearchModel model = base._model as ITextSearchModel;
            PresenterBase.SetViewPropertiesFromModel<ITextSearchView, ITextSearchModel>(
                ref view, model
            );

            SyncContext.Post(delegate {
                view.RefreshAccessToken();
                view.RenderSearchModeSelections();
                view.SetSearchResultLimit(model.SearchResultsLimit);
            }, null);
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                // TODO:
                // Wire up events
                ITextSearchView view = base._view as ITextSearchView;
                view.DataChanged += OnDataChanged;
                view.CommandMemberSearch += OnCommandMemberSearch;
                view.CommandClear += OnCommandClear;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                // TODO
                // Unwire events
                ITextSearchView view = base._view as ITextSearchView;
                view.DataChanged -= OnDataChanged;
                view.CommandMemberSearch -= OnCommandMemberSearch;
                view.CommandClear -= OnCommandClear;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp() {
        }

        public void UpdateSettings() {
            OnDataChanged(this, new EventArgs());
        }

        #region REST Service

        private bool SearchFiles(
            IMemberServices service,
            string memberId,
            ITextSearchModel model,
            string email,
            IMainPresenter presenter) {
            bool filesAdded = false;
            bool SuppressStatus = ApplicationResource.SuppressFilenamesInStatus;
            try {
                service.SearchFilesUrl = ApplicationResource.ActionFileSearch;
                IDataResponse response = service.SearchFiles(new MemberData() {
                    SearchText = model.QueryString,
                    SearchLimit = ApplicationResource.SearchFileCountLimit,//model.SearchResultsLimit,
                    SearchMode = model.GetSearchModeForService(),
                    MemberId = memberId
                }, model.AccessToken);

                if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                    if (response.Data != null) {
                        string data = response.Data.ToString();
                        dynamic jsonDataSearch = JsonConvert.DeserializeObject<dynamic>(data);
                        if (jsonDataSearch["matches"] != null &&
                            jsonDataSearch["matches"].ToString() != "[]") {
                            int matchCount = jsonDataSearch["matches"].Count;
                            for (int j = 0; j < matchCount; j++) {
                                string pathLower = jsonDataSearch["matches"][j]["metadata"]["path_lower"];
                                // update model
                                MemberListViewItemModel item = new MemberListViewItemModel() {
                                    Email = email,
                                    Path = pathLower,
                                    MemberId = memberId
                                };
                                // add searched members to list.
                                model.MemberList.Add(item);

                                SyncContext.Post(delegate {
                                    if (!SuppressStatus)
                                    {
                                        presenter.UpdateProgressInfo(string.Format("Member: {0} File : {1}", email, item.Path));
                                    }
                                    else
                                    {
                                        presenter.UpdateProgressInfo(string.Format("Member: {0} File : Suppressing filename status...", email));
                                    }
                                }, null);
                            }

                            if (matchCount > 0) {
                                filesAdded = true;
                            }
                        }
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return filesAdded;
        }

        private void SearchMembers(ITextSearchModel model) {
            if (!string.IsNullOrEmpty(model.QueryString) &&
               !string.IsNullOrEmpty(model.AccessToken)) {
                MemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                service.ListMembersUrl = ApplicationResource.ActionListMembers;
                IDataResponse response = service.ListMembers(new MemberData() {
                    SearchLimit = model.SearchResultsLimit
                }, model.AccessToken);
                IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

                if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                    if (response.Data != null) {
                        string data = response.Data.ToString();
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                        // clear existing data first
                        model.MemberList.Clear();

                        int resultCount = jsonData["members"].Count;
                        for (int i = 0; i < resultCount; i++) {
                            dynamic idObj = jsonData["members"][i]["profile"]["team_member_id"];
                            dynamic emailObj = jsonData["members"][i]["profile"]["email"];
                            string memberId = idObj.Value as string;
                            string email = emailObj.Value as string;

                            // update model
                            MemberListViewItemModel lvItem = new MemberListViewItemModel() {
                                Email = email,
                                MemberId = memberId
                            };

                            // perform file search
                            if (!SearchFiles(service, memberId, model, email, presenter)) {
                                model.MemberList.Add(lvItem);
                            }
                            SyncContext.Post(delegate {
                                presenter.UpdateProgressInfo(string.Format("Searching Content(s) From : {0}", email));
                            }, null);
                        }
                    }
                } else {
                    // TODO: Report error
                }
            }
        }

        #endregion REST Service

        #region Events

        private void OnDataChanged(object sender, System.EventArgs e) {
            ITextSearchView view = base._view as ITextSearchView;
            ITextSearchModel model = base._model as ITextSearchModel;
            PresenterBase.SetModelPropertiesFromView<ITextSearchModel, ITextSearchView>(
                ref model, view
            );
        }

        private void OnCommandMemberSearch(object sender, System.EventArgs e) {
            ITextSearchModel model = base._model as ITextSearchModel;
            ITextSearchView view = base._view as ITextSearchView;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            // notify view to mark start of process
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }

            // TODO: to improve stability, we will need to ensure to kill
            // thread when user exits application while thread is running for REST service call
            Thread memberSearch = new Thread(() => {
                if (string.IsNullOrEmpty(model.QueryString)) {
                    SyncContext.Post(delegate {
                        presenter.ShowErrorMessage(ErrorMessages.MISSING_QUERYSTRING, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.UpdateProgressInfo("");
                        presenter.ActivateSpinner(false);
                        presenter.EnableControl(true);
                    }, null);
                } else if (string.IsNullOrEmpty(model.AccessToken)) {
                    SyncContext.Post(delegate {
                        presenter.ShowErrorMessage(ErrorMessages.INVALID_TOKEN, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.UpdateProgressInfo("");
                        presenter.ActivateSpinner(false);
                        presenter.EnableControl(true);
                    }, null);
                } else {
                    // perform search
                    this.SearchMembers(model);
                    if (SyncContext != null) {
                        SyncContext.Post(delegate {
                            // update result and update view.
                            view.RenderMembersSearchResult();
                            presenter.UpdateProgressInfo("Completed");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            // start async search
            memberSearch.Start();
        }

        private void OnCommandClear(object sender, EventArgs e) {
            ITextSearchModel model = base._model as ITextSearchModel;
            ITextSearchView view = base._view as ITextSearchView;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            model.QueryString = string.Empty;
            model.SelectedSearchMode = TextSearchModel.TextSearchMode.Filename_only.ToString();
            model.SearchResultsLimit = ApplicationResource.SearchDefaultLimit;
            model.MemberList = new List<MemberListViewItemModel>();

            PresenterBase.SetViewPropertiesFromModel<ITextSearchView, ITextSearchModel>(
                ref view, model
            );
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    view.RenderComponents();
                }, null);
            }
        }

        #endregion Events
    }
}