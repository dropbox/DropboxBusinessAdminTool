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
                view.CommandExportTeamFolders += OnCommandExportTeamFolders;
                view.CommandExportTeamFoldersPerms += OnCommandExportTeamFoldersPerms;
                view.CommandLoadTeamFolders += OnCommandLoadTeamFolders;
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
                view.CommandExportTeamFolders -= OnCommandExportTeamFolders;
                view.CommandExportTeamFoldersPerms -= OnCommandExportTeamFoldersPerms;
                view.CommandLoadTeamFolders -= OnCommandLoadTeamFolders;
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
                        Status = status,
                        IsChecked = true
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

        public bool LoadTeamFoldersInputFile(ITeamFoldersModel model, IMainPresenter presenter)
        {
            bool loaded = true;
            try
            {
                FileInfo fInfo = new FileInfo(model.TeamFoldersInputFilePath);
                if (fInfo.Exists)
                {
                    // try load.
                    model.TeamFolders.Clear();
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
                                TeamFoldersListViewItemModel lvItem = new TeamFoldersListViewItemModel()
                                {
                                    TeamFolderName = reader.GetField<string>(0),
                                    IsChecked = true
                                };
                                model.TeamFolders.Add(lvItem);
                            }
                            catch
                            {
                                throw new InvalidDataException(ErrorMessages.INVALID_CSV_DATA);
                            }
                        }
                        if (model.TeamFolders.Any())
                        {
                            loaded = true;
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
                // error message.
                SyncContext.Post(delegate {
                    presenter.ShowErrorMessage(e.Message, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return loaded;
        }

        private List<Tuple<string, string, string>> GetSharedFolders(string memberId, ITeamFoldersModel model, IMainPresenter presenter)
        {
            IMemberServices service = service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.ListSharedFoldersUrl = ApplicationResource.ActionSharingListFolders;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            var sharedFolders = new List<Tuple<string, string, string>>();

            IDataResponse response = service.ListSharedFolders(new MemberData()
            {
                MemberId = memberId
            }, ApplicationResource.DefaultAccessToken);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (response.Data != null)
                {
                    string data = response.Data.ToString();
                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                    int resultCount = jsonData["entries"].Count;
                    for (int i = 0; i < resultCount; i++)
                    {
                        dynamic entries = jsonData["entries"][i];
                        dynamic pathLower = Convert.ToString(entries["path_lower"]);
                        dynamic sharedFolderId = Convert.ToString(entries["shared_folder_id"]);
                        dynamic sharedFolderName = Convert.ToString(entries["name"]);
                        dynamic isTeamFolder = Convert.ToBoolean(entries["is_team_folder"]);

                        string path = string.Empty;
                        if (pathLower != null)
                        {
                            path = pathLower;
                        }

                        var tuple = Tuple.Create(sharedFolderId, sharedFolderName, path);
                        if (!sharedFolders.Contains(tuple) && isTeamFolder)
                        {
                            sharedFolders.Add(tuple);
                        }
                    }
                    //if the group count is above limit - default 1000 we need to grab the cursor and call continue
                    string cursor = jsonData["cursor"];
                    while (!string.IsNullOrEmpty(cursor))
                    {
                        service.ListSharedFoldersUrl = ApplicationResource.ActionSharingListFoldersContinuation;
                        IDataResponse responseCont = service.ListSharedFolders(new MemberData()
                        {
                            MemberId = memberId,
                            Cursor = cursor
                        }, model.AccessToken);

                        string dataCont = responseCont.Data.ToString();
                        dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                        int resultContCount = jsonDataCont["entries"].Count;
                        for (int i = 0; i < resultContCount; i++)
                        {
                            dynamic entries = jsonDataCont["entries"][i];
                            dynamic pathLower = Convert.ToString(entries["path_lower"]);
                            dynamic sharedFolderId = Convert.ToString(entries["shared_folder_id"]);
                            dynamic sharedFolderName = Convert.ToString(entries["name"]);
                            dynamic isTeamFolder = Convert.ToBoolean(entries["is_team_folder"]);

                            string path = string.Empty;
                            if (pathLower != null)
                            {
                                path = pathLower;
                            }

                            var tuple = Tuple.Create(sharedFolderId, sharedFolderName, path);
                            if (!sharedFolders.Contains(tuple) && isTeamFolder)
                            {
                                sharedFolders.Add(tuple);
                            }
                        }
                        cursor = jsonDataCont["cursor"];
                    }
                }
            }
            return sharedFolders;
        }

        private void GetTeamFoldersPerms(ITeamFoldersModel model, IMainPresenter presenter)
        {
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.ExportGroupPermsUrl = ApplicationResource.ActionSharingListFolderMembers;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            List<Tuple<string, string, string>> sharedFolders;
            //Get team member id's for each checked email to remove in objectlistview
            IList<TeamListViewItemModel> members = SearchOwners(model, presenter);
            string memberId = string.Empty;
            foreach (var memberitem in members)
            {
                if (!string.IsNullOrEmpty(memberitem.TeamId))
                {
                    memberId = memberitem.TeamId;
                    sharedFolders = this.GetSharedFolders(memberId, model, presenter);

                    foreach (var item in sharedFolders)
                    {
                        IDataResponse response = service.ExportGroupPerms(new MemberData()
                        {
                            MemberId = memberId
                        }, item.Item1, ApplicationResource.DefaultAccessToken);

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            if (response.Data != null)
                            {
                                string data = response.Data.ToString();
                                dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);
                                //users
                                int resultCount = jsonData["users"].Count;
                                for (int i = 0; i < resultCount; i++)
                                {
                                    dynamic users = jsonData["users"][i];
                                    dynamic type = Convert.ToString(users["access_type"][".tag"]);
                                    dynamic accountId = Convert.ToString(users["user"]["account_id"]);
                                    dynamic id = Convert.ToString(users["user"]["team_member_id"]);
                                    dynamic sharedFolderId = item.Item1;
                                    dynamic sharedFolderName = item.Item2;
                                    dynamic path = item.Item3;

                                    // update model
                                    TeamFoldersPermsItemModel lvItem1 = new TeamFoldersPermsItemModel()
                                    {
                                        TeamFolderName = sharedFolderName,
                                        TeamFolderPath = path,
                                        TeamFolderMember = accountId,
                                        TeamFolderMemberId = id,
                                        AccessType = type,
                                        MemberCount = "1"
                                    };
                                    bool contains = ((model.TeamFoldersPerms.Any(p => p.TeamFolderName == sharedFolderName)) && ((model.TeamFoldersPerms.Any(p => p.TeamFolderMemberId == id))));
                                    if (!contains)
                                    {
                                        model.TeamFoldersPerms.Add(lvItem1);
                                    } 
                                }
                                //groups
                                int groupCount = jsonData["groups"].Count;
                                for (int i = 0; i < groupCount; i++)
                                {
                                    dynamic groups = jsonData["groups"][i];
                                    dynamic groupName = Convert.ToString(groups["group"]["group_name"]);
                                    dynamic groupId = Convert.ToString(groups["group"]["group_id"]);
                                    dynamic accessType = Convert.ToString(groups["access_type"][".tag"]);
                                    dynamic memberCount = Convert.ToString(groups["group"]["member_count"]);
                                    dynamic sharedFolderId = item.Item1;
                                    dynamic sharedFolderName = item.Item2;
                                    dynamic path = item.Item3;

                                    // update model
                                    TeamFoldersPermsItemModel lvItem1 = new TeamFoldersPermsItemModel()
                                    {
                                        TeamFolderName = sharedFolderName,
                                        TeamFolderPath = path,
                                        TeamFolderMember = groupName,
                                        TeamFolderMemberId = groupId,
                                        AccessType = accessType,
                                        MemberCount = memberCount
                                    };
                                    bool contains = ((model.TeamFoldersPerms.Any(p => p.TeamFolderName == sharedFolderName)) && ((model.TeamFoldersPerms.Any(p => p.TeamFolderMemberId == groupId))));
                                    if (!contains)
                                    {
                                        model.TeamFoldersPerms.Add(lvItem1);
                                    }
                                }
                                //if the group count is above limit - default 1000 we need to grab the cursor and call continue
                                string cursor = jsonData["cursor"];

                                while (!string.IsNullOrEmpty(cursor))
                                {
                                    service.ExportGroupPermsUrl = ApplicationResource.ActionSharingListFolderMembersContinuation;
                                    IDataResponse responseCont = service.ExportGroupPerms(new MemberData()
                                    {
                                        MemberId = memberId,
                                        Cursor = cursor
                                    }, item.Item1, model.AccessToken);

                                    string dataCont = responseCont.Data.ToString();
                                    dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                                    //users
                                    int resultCountCont = jsonDataCont["users"].Count;
                                    for (int i = 0; i < resultCountCont; i++)
                                    {
                                        dynamic users = jsonDataCont["users"][i];
                                        dynamic type = Convert.ToString(users["access_type"][".tag"]);
                                        dynamic accountId = Convert.ToString(users["user"]["account_id"]);
                                        dynamic id = Convert.ToString(users["user"]["team_member_id"]);
                                        dynamic sharedFolderId = item.Item1;
                                        dynamic sharedFolderName = item.Item2;
                                        dynamic path = item.Item3;

                                        // update model
                                        TeamFoldersPermsItemModel lvItem1 = new TeamFoldersPermsItemModel()
                                        {
                                            TeamFolderName = sharedFolderName,
                                            TeamFolderPath = path,
                                            TeamFolderMember = accountId,
                                            TeamFolderMemberId = id,
                                            AccessType = type,
                                            MemberCount = "1"
                                        };
                                        bool contains = ((model.TeamFoldersPerms.Any(p => p.TeamFolderName == sharedFolderName)) && ((model.TeamFoldersPerms.Any(p => p.TeamFolderMemberId == id))));
                                        if (!contains)
                                        {
                                            model.TeamFoldersPerms.Add(lvItem1);
                                        }
                                    }
                                    //groups
                                    int groupCountCont = jsonDataCont["groups"].Count;
                                    for (int i = 0; i < groupCountCont; i++)
                                    {
                                        dynamic groups = jsonDataCont["groups"][i];
                                        dynamic groupName = Convert.ToString(groups["group"]["group_name"]);
                                        dynamic groupId = Convert.ToString(groups["group"]["group_id"]);
                                        dynamic accessType = Convert.ToString(groups["access_type"][".tag"]);
                                        dynamic memberCount = Convert.ToString(groups["group"]["member_count"]);
                                        dynamic sharedFolderId = item.Item1;
                                        dynamic sharedFolderName = item.Item2;
                                        dynamic path = item.Item3;

                                        // update model
                                        TeamFoldersPermsItemModel lvItem1 = new TeamFoldersPermsItemModel()
                                        {
                                            TeamFolderName = sharedFolderName,
                                            TeamFolderPath = path,
                                            TeamFolderMember = groupName,
                                            TeamFolderMemberId = groupId,
                                            AccessType = accessType,
                                            MemberCount = memberCount
                                        };
                                        bool contains = ((model.TeamFoldersPerms.Any(p => p.TeamFolderName == sharedFolderName)) && ((model.TeamFoldersPerms.Any(p => p.TeamFolderMemberId == groupId))));
                                        if (!contains)
                                        {
                                            model.TeamFoldersPerms.Add(lvItem1);
                                        }
                                    }
                                    cursor = jsonDataCont["cursor"];
                                }
                            }
                        }
                    }
                }
            }     
        }

        public IList<TeamListViewItemModel> SearchOwners(ITeamFoldersModel model, IMainPresenter presenter)
        {
            IList<TeamListViewItemModel> members = new List<TeamListViewItemModel>();
            if (!string.IsNullOrEmpty(model.AccessToken))
            {
                MemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                service.ListMembersUrl = ApplicationResource.ActionListMembers;
                service.UserAgentVersion = ApplicationResource.UserAgent;
                IDataResponse response = service.ListMembers(new MemberData()
                {
                    SearchLimit = ApplicationResource.SearchDefaultLimit
                }, model.AccessToken);

                if (SyncContext != null)
                {
                    SyncContext.Post(delegate {
                        presenter.UpdateProgressInfo("Searching users...");
                    }, null);
                }
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.Data != null)
                    {
                        string data = response.Data.ToString();
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);
                        int resultCount = jsonData["members"].Count;
                        int total = 0;
                        for (int i = 0; i < resultCount; i++)
                        {
                            dynamic profile = jsonData["members"][i]["profile"];
                            dynamic idObj = profile["team_member_id"];
                            dynamic emailObj = profile["email"];
                            dynamic status = profile["status"];
                            if (status != null && (status[".tag"].ToString().Equals("active") || status[".tag"].ToString().Equals("suspended")))
                            {
                                string teamId = idObj.Value as string;
                                string email = emailObj.Value as string;
                                // update model
                                TeamListViewItemModel lvItem = new TeamListViewItemModel()
                                {
                                    Email = email,
                                    TeamId = teamId
                                };
                                members.Add(lvItem);
                            }
                            if (SyncContext != null)
                            {
                                SyncContext.Post(delegate {
                                    presenter.UpdateProgressInfo("Scanning Account(s): " + (++total));
                                }, null);
                            }
                            Thread.Sleep(1);
                        }
                        // collect more.
                        bool hasMore = jsonData["has_more"];
                        string cursor = jsonData["cursor"];

                        while (hasMore)
                        {
                            service.ListMembersContinuationUrl = ApplicationResource.ActionListMembersContinuation;
                            service.UserAgentVersion = ApplicationResource.UserAgent;
                            IDataResponse responseCont = service.ListMembersContinuation(new MemberData()
                            {
                                Cursor = cursor
                            }, model.AccessToken);

                            string dataCont = responseCont.Data.ToString();
                            dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                            int resultContCount = jsonDataCont["members"].Count;
                            for (int i = 0; i < resultContCount; i++)
                            {
                                dynamic profile = jsonDataCont["members"][i]["profile"];
                                dynamic idObj = profile["team_member_id"];
                                dynamic emailObj = profile["email"];
                                dynamic status = profile["status"];

                                string teamId = idObj.Value as string;
                                string email = emailObj.Value as string;

                                if (status != null && (status[".tag"].ToString().Equals("active") || status[".tag"].ToString().Equals("suspended")))
                                {
                                    // update model
                                    TeamListViewItemModel lvItem = new TeamListViewItemModel()
                                    {
                                        Email = email,
                                        TeamId = teamId
                                    };
                                    members.Add(lvItem);
                                }
                                if (SyncContext != null)
                                {
                                    SyncContext.Post(delegate {
                                        presenter.UpdateProgressInfo("Scanning Account(s): " + (++total));
                                    }, null);
                                }
                                Thread.Sleep(1);
                            }
                            hasMore = jsonDataCont["has_more"];
                            cursor = jsonDataCont["cursor"];
                        }
                    }
                }
            }
            return members;
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
            bool multiCheck = view.MultiTeamFoldersCreateCheck();
            int teamFolderCount = 0;

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
                string response = string.Empty;
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
                    if (multiCheck)
                    {
                        
                        foreach (TeamFoldersListViewItemModel item in model.TeamFolders)
                        {
                            response = this.CreateTeamFolder(model, item.TeamFolderName, presenter);
                            teamFolderCount++;
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
                                //view.RenderTeamFoldersList();
                                presenter.ActivateSpinner(false);
                                presenter.EnableControl(true);
                                presenter.UpdateProgressInfo("Completed. Total Team folders created: [" + teamFolderCount.ToString() + "]");
                            }, null);
                        }
                    }
                    if (!multiCheck)
                    {
                        response = this.CreateTeamFolder(model, teamFolderName, presenter);
                        teamFolderCount++;

                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate
                            {
                                // update result and update view.
                                PresenterBase.SetViewPropertiesFromModel<ITeamFoldersView, ITeamFoldersModel>(
                                    ref view, model
                                );
                                // update result and update view.
                                //view.RenderTeamFoldersList();
                                presenter.ActivateSpinner(false);
                                presenter.EnableControl(true);
                                presenter.UpdateProgressInfo("Completed. Total Team folders created: [" + teamFolderCount.ToString() + "]");
                            }, null);
                        }
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
                        }, null);
                    }
                }
            });
            setfoldersyncsetting.Start();
        }

        private void OnCommandExportTeamFolders(object sender, System.EventArgs e)
        {
            ITeamFoldersView view = base._view as ITeamFoldersView;
            ITeamFoldersModel model = base._model as ITeamFoldersModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }
            Thread exportteamfolders = new Thread(() => {
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
                            PresenterBase.SetViewPropertiesFromModel<ITeamFoldersView, ITeamFoldersModel>(
                                ref view, model
                            );
                            string sPath = string.Empty;

                            if (model.TeamFolders.Count > 0)
                            {
                                //create CSV file in My Documents folder
                                sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TeamFolderExport.csv";
                                CsvConfiguration config = new CsvConfiguration()
                                {
                                    HasHeaderRecord = true,
                                    Delimiter = ",",
                                    Encoding = System.Text.Encoding.UTF8
                                };
                                config.RegisterClassMap(new TeamFoldersHeaderMap());
                                int total = model.TeamFolders.Count;
                                using (CsvWriter writer = new CsvWriter(new StreamWriter(sPath), config))
                                {
                                    writer.WriteHeader<TeamFoldersHeaderRecord>();
                                    int count = 0;
                                    foreach (var item in model.TeamFolders)
                                    {
                                        writer.WriteField<string>(item.TeamFolderName);
                                        writer.WriteField<string>(item.TeamFolderId);
                                        writer.WriteField<string>(item.Status);
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
                            if (model.TeamFolders.Count == 0)
                            {
                                presenter.UpdateProgressInfo("No team folders were chosen to export.");
                            }
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            exportteamfolders.Start();
        }

        private void OnCommandExportTeamFoldersPerms(object sender, System.EventArgs e)
        {
            ITeamFoldersView view = base._view as ITeamFoldersView;
            ITeamFoldersModel model = base._model as ITeamFoldersModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }
            Thread exportteamfoldersperms = new Thread(() => {
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
                    this.GetTeamFoldersPerms(model, presenter);

                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<ITeamFoldersView, ITeamFoldersModel>(
                                ref view, model
                            );
                            string sPath = string.Empty;
                            if (model.TeamFoldersPerms.Count > 0)
                            {
                                //create CSV file in My Documents folder
                                sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TeamFolderPermsExport.csv";
                                CsvConfiguration config = new CsvConfiguration()
                                {
                                    HasHeaderRecord = true,
                                    Delimiter = ",",
                                    Encoding = System.Text.Encoding.UTF8
                                };
                                config.RegisterClassMap(new TeamFoldersMembersHeaderMap());
                                int total = model.TeamFoldersPerms.Count;
                                using (CsvWriter writer = new CsvWriter(new StreamWriter(sPath), config))
                                {
                                    writer.WriteHeader<TeamFoldersMembersHeaderRecord>();
                                    int count = 0;
                                    foreach (var item in model.TeamFoldersPerms)
                                    {
                                        writer.WriteField<string>(item.TeamFolderName);
                                        writer.WriteField<string>(item.TeamFolderPath);
                                        writer.WriteField<string>(item.TeamFolderMember);
                                        writer.WriteField<string>(item.TeamFolderMemberId);
                                        writer.WriteField<string>(item.AccessType);
                                        writer.WriteField<string>(item.MemberCount);
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
                            if (model.TeamFoldersPerms.Count == 0)
                            {
                                presenter.UpdateProgressInfo("No team folders were available to export.");
                            }
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            exportteamfoldersperms.Start();
        }

        private void OnCommandLoadTeamFolders(object sender, EventArgs e)
        {
            ITeamFoldersView view = base._view as ITeamFoldersView;
            ITeamFoldersModel model = base._model as ITeamFoldersModel;
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
                    bool loaded = this.LoadTeamFoldersInputFile(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate {
                            // update result and update view.
                            view.RenderTeamFoldersList();
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
            ITeamFoldersView view = base._view as ITeamFoldersView;
            ITeamFoldersModel model = base._model as ITeamFoldersModel;
            PresenterBase.SetModelPropertiesFromView<ITeamFoldersModel, ITeamFoldersView>(
                ref model, view
            );
        }

        #endregion Events
    }
}