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

    public class TeamHealthPresenter
        : PresenterBase, ITeamHealthPresenter {

        public TeamHealthPresenter(ITeamHealthModel model, ITeamHealthView view)
            : base(model, view) {
        }

        protected override void Initialize() {
            ITeamHealthView view = base._view as ITeamHealthView;
            ITeamHealthModel model = base._model as ITeamHealthModel;
            PresenterBase.SetViewPropertiesFromModel<ITeamHealthView, ITeamHealthModel>(
                ref view, model
            );

            SyncContext.Post(delegate {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                ITeamHealthView view = base._view as ITeamHealthView;
                view.DataChanged += OnDataChanged;
                //view.CommandLoadTeamFolders += OnCommandLoadTeamFolders;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                ITeamHealthView view = base._view as ITeamHealthView;
                view.DataChanged -= OnDataChanged;
                //view.CommandLoadTeamFolders -= OnCommandLoadTeamFolders;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp() {
        }

        public void UpdateSettings() {
            OnDataChanged(this, new EventArgs());
        }

        #region REST Service

        private void GetPaperDocs(ITeamHealthModel model, IMainPresenter presenter)
        {
            IMemberServices service = service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.ListTeamFolderUrl = ApplicationResource.ActionListTeamFolder;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            string fileAccessToken = ApplicationResource.DefaultAccessToken;
            IDataResponse response = service.ListTeamFolders(fileAccessToken);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (response.Data != null)
                {
                    string data = response.Data.ToString();
                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                    // clear existing data first
                    //model.TeamHealth.Clear();
                    //changed from entries to team_folders
                    int resultCount = jsonData["team_folders"].Count;
                    for (int i = 0; i < resultCount; i++)
                    {
                        dynamic team_folders = jsonData["team_folders"][i];
                        dynamic teamFolderName = team_folders["name"];
                        dynamic teamFolderId = team_folders["team_folder_id"];
                        dynamic status = team_folders["status"][".tag"];

                    // update model
                    TeamFoldersListViewItemModel lvItem = new TeamFoldersListViewItemModel()
                    {
                        TeamFolderName = teamFolderName,
                        TeamFolderId = teamFolderId,
                        Status = status,
                        IsChecked = true
                    };
                        //model.TeamHealth.Add(lvItem);
                    }
                }
            }
        }

        #endregion REST Service

        #region Events

        private void OnCommandLoadTeamFolders(object sender, EventArgs e)
        {
            ITeamHealthView view = base._view as ITeamHealthView;
            ITeamHealthModel model = base._model as ITeamHealthModel;
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
                    //bool loaded = this.LoadTeamFoldersInputFile(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate {
                            // update result and update view.
                            view.RenderTeamHealthList();
                            presenter.UpdateProgressInfo("Team Folders CSV Loaded");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            teamfoldersLoad.Start();
        }

        private void OnDataChanged(object sender, System.EventArgs e) {
            ITeamHealthView view = base._view as ITeamHealthView;
            ITeamHealthModel model = base._model as ITeamHealthModel;
            PresenterBase.SetModelPropertiesFromView<ITeamHealthModel, ITeamHealthView>(
                ref model, view
            );
        }

        #endregion Events
    }
}