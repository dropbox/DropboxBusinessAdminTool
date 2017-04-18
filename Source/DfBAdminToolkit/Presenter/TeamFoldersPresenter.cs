namespace DfBAdminToolkit.Presenter {

    using Common.Services;
    using Common.Utils;
    using Model;
    using View;
    using Newtonsoft.Json;
    using System;
    using System.Configuration;
    using System.Linq;
    using System.Net;
    using System.Threading;

    public class TeamFoldersPresenter
        : PresenterBase, ITeamFoldersPresenter {

        public TeamFoldersPresenter(ITeamFoldersModel model, ITeamFoldersView view)
            : base(model, view) {
        }

        protected override void Initialize() {
            ITeamFoldersView view = base._view as ITeamFoldersView;
            ITeamFoldersModel model = base._model as ITeamFoldersModel;
            PresenterBase.SetViewPropertiesFromModel<ITeamFoldersView, ITeamFoldersModel>(
                ref view, model
            );

            SyncContext.Post(delegate {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                ITeamFoldersView view = base._view as ITeamFoldersView;
                view.DataChanged += OnDataChanged;
                view.CommandGetTeamFolders += OnCommandGetTeamFolders;
                view.CommandCreateTeamFolder += OnCommandCreateTeamFolder;
                view.CommandSetFolderStatus += OnCommandSetFolderStatus;
                view.CommandSetFolderSyncSetting += OnCommandSetFolderSyncSetting;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                ITeamFoldersView view = base._view as ITeamFoldersView;
                view.DataChanged -= OnDataChanged;
                view.CommandGetTeamFolders -= OnCommandGetTeamFolders;
                view.CommandCreateTeamFolder -= OnCommandCreateTeamFolder;
                view.CommandSetFolderStatus -= OnCommandSetFolderStatus;
                view.CommandSetFolderSyncSetting -= OnCommandSetFolderSyncSetting;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp() {
        }

        public void UpdateSettings() {
            OnDataChanged(this, new EventArgs());
        }

        #region REST Service

        private void GetTeamFolders(ITeamFoldersModel model, IMainPresenter presenter)
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
                    model.TeamFolders.Clear();
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
                        Status = status
                    };
                        model.TeamFolders.Add(lvItem);
                    }
                }
            }
        }

        private string CreateTeamFolder(ITeamFoldersModel model, string teamFolderName, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            string fileAccessToken = ApplicationResource.DefaultAccessToken;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.CreateTeamFolderUrl = ApplicationResource.ActionCreateTeamFolder;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            IServiceResponse response = service.CreateTeamFolder(teamFolderName, fileAccessToken);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate
                    {
                        presenter.UpdateProgressInfo(string.Format("Created team folder [" + teamFolderName + "]"));
                    }, null);
                }
            }
            else
            {
                errorMessage = ErrorMessages.FAILED_TO_CREATE_TEAMFOLDER;
            }
            return errorMessage;
        }

        private string SetFolderStatus(ITeamFoldersModel model, string teamFolderId, bool activeSetting, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            string fileAccessToken = ApplicationResource.DefaultAccessToken;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            if (activeSetting)
            {
                service.ActivateTeamFolderUrl = ApplicationResource.ActionActivateTeamFolder;
            }
            if (!activeSetting)
            {
                service.ArchiveTeamFolderUrl = ApplicationResource.ActionArchiveTeamFolder;
            }
            service.UserAgentVersion = ApplicationResource.UserAgent;
            IServiceResponse response = service.SetTeamFolderStatus(teamFolderId, activeSetting, fileAccessToken);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate
                    {
                        presenter.UpdateProgressInfo(string.Format("Updated team folder status for [" + teamFolderId + "]"));
                    }, null);
                }
            }
            else
            {
                errorMessage = ErrorMessages.FAILED_TO_UPDATE_TEAM_FOLDER_STATUS;
            }
            return errorMessage;
        }

        private string SetDefaultSyncSetting(ITeamFoldersModel model, string teamFolderId, bool syncSetting, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            string fileAccessToken = ApplicationResource.DefaultAccessToken;
            string syncStringSetting = "sync";
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.SyncSettingTeamFolderUrl = ApplicationResource.ActionUpdateDefaultSyncSettingTeamFolder;
            if (!syncSetting)
            {
                syncStringSetting = "no_sync";
            }
            service.UserAgentVersion = ApplicationResource.UserAgent;
            IServiceResponse response = service.SetFolderSyncSetting(teamFolderId, syncStringSetting, fileAccessToken);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate
                    {
                        presenter.UpdateProgressInfo(string.Format("Updated default sync setting for [" + teamFolderId + "]"));
                    }, null);
                }
            }
            if (response.StatusCode.ToString() == "BadRequest")
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate {
                        presenter.UpdateProgressInfo("Error: This endpoint is only available for teams with access to managed sync");
                    }, null);
                }
            }
            else
            {
                errorMessage = ErrorMessages.FAILED_TO_UPDATE_TEAM_FOLDER_STATUS;
            }
            return errorMessage;
        }

        #endregion REST Service

        #region Events

        private void OnCommandGetTeamFolders(object sender, System.EventArgs e)
        {
            ITeamFoldersView view = base._view as ITeamFoldersView;
            ITeamFoldersModel model = base._model as ITeamFoldersModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }
            Thread getteamfolders = new Thread(() => {
                if (string.IsNullOrEmpty(model.AccessToken))
                {
                    SyncContext.Post(delegate {
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("");
                    }, null);
                }
                else
                {
                    this.GetTeamFolders(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<ITeamFoldersView, ITeamFoldersModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderTeamFoldersList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Team folder list completed.");
                        }, null);
                    }
                }
            });
            getteamfolders.Start();
        }

        private void OnCommandCreateTeamFolder(object sender, System.EventArgs e)
        {
            ITeamFoldersView view = base._view as ITeamFoldersView;
            ITeamFoldersModel model = base._model as ITeamFoldersModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            string teamFolderName = view.TeamFolderName;
            bool syncSetting = view.SyncSetting;

            if (SyncContext != null)
            {
                SyncContext.Post(delegate
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");

                }, null);
            }
            Thread createteamfolder = new Thread(() =>
            {
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
                    this.CreateTeamFolder(model, teamFolderName, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<ITeamFoldersView, ITeamFoldersModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderTeamFoldersList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Completed.");
                        }, null);
                    }
                }
            });
            createteamfolder.Start();
        }

        private void OnCommandSetFolderStatus(object sender, System.EventArgs e)
        {
            ITeamFoldersView view = base._view as ITeamFoldersView;
            ITeamFoldersModel model = base._model as ITeamFoldersModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            TeamFoldersModel teamModel = view.GetTeamFolderIds();
            bool activeSetting = view.ActiveSetting;

            if (SyncContext != null)
            {
                SyncContext.Post(delegate
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");

                }, null);
            }
            Thread setfolderstatus = new Thread(() =>
            {
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
                    foreach (TeamFoldersListViewItemModel lvItem in teamModel.TeamFolders)
                    {
                        this.SetFolderStatus(model, lvItem.TeamFolderId, activeSetting, presenter);
                    }
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<ITeamFoldersView, ITeamFoldersModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderTeamFoldersList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Completed.");
                        }, null);
                    }
                }
            });
            setfolderstatus.Start();
        }

        private void OnCommandSetFolderSyncSetting(object sender, System.EventArgs e)
        {
            ITeamFoldersView view = base._view as ITeamFoldersView;
            ITeamFoldersModel model = base._model as ITeamFoldersModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            TeamFoldersModel teamModel = view.GetTeamFolderIds();
            bool syncSetting = view.SyncSetting;

            if (SyncContext != null)
            {
                SyncContext.Post(delegate
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");

                }, null);
            }
            Thread setfoldersyncsetting = new Thread(() =>
            {
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
                    foreach (TeamFoldersListViewItemModel lvItem in teamModel.TeamFolders)
                    {
                        this.SetDefaultSyncSetting(model, lvItem.TeamFolderId, syncSetting, presenter);
                    }
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<ITeamFoldersView, ITeamFoldersModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderTeamFoldersList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            //presenter.UpdateProgressInfo("Completed.");
                        }, null);
                    }
                }
            });
            setfoldersyncsetting.Start();
        }

        private void OnDataChanged(object sender, System.EventArgs e) {
            ITeamFoldersView view = base._view as ITeamFoldersView;
            ITeamFoldersModel model = base._model as ITeamFoldersModel;
            PresenterBase.SetModelPropertiesFromView<ITeamFoldersModel, ITeamFoldersView>(
                ref model, view
            );
        }

        #endregion Events
    }
}