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

    public class PaperPresenter
        : PresenterBase, IPaperPresenter {

        IList<PaperListViewItemModel> docIds;

        public PaperPresenter(IPaperModel model, IPaperView view)
            : base(model, view) {
        }

        protected override void Initialize() {
            IPaperView view = base._view as IPaperView;
            IPaperModel model = base._model as IPaperModel;
            PresenterBase.SetViewPropertiesFromModel<IPaperView, IPaperModel>(
                ref view, model
            );

            SyncContext.Post(delegate {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                IPaperView view = base._view as IPaperView;
                view.DataChanged += OnDataChanged;
                view.CommandGetPaper += OnCommandGetPaper;
                view.CommandCreatePaper += OnCommandCreatePaper;
                view.CommandSetPaperStatus += OnCommandSetPaperStatus;
                view.CommandSetPaperSyncSetting += OnCommandSetPaperSyncSetting;
                view.CommandExportPaper += OnCommandExportPaper;
                view.CommandExportPaperPerms += OnCommandExportPaperPerms;
                view.CommandLoadPaper += OnCommandLoadPaper;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                IPaperView view = base._view as IPaperView;
                view.DataChanged -= OnDataChanged;
                view.CommandGetPaper -= OnCommandGetPaper;
                view.CommandCreatePaper -= OnCommandCreatePaper;
                view.CommandSetPaperStatus -= OnCommandSetPaperStatus;
                view.CommandSetPaperSyncSetting -= OnCommandSetPaperSyncSetting;
                view.CommandExportPaper -= OnCommandExportPaper;
                view.CommandExportPaperPerms -= OnCommandExportPaperPerms;
                view.CommandLoadPaper -= OnCommandLoadPaper;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp() {
        }

        public void UpdateSettings() {
            OnDataChanged(this, new EventArgs());
        }

        #region REST Service

        private void GetPaperDocs(IPaperModel model, IMainPresenter presenter)
        {
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.ListPaperDocsUrl = ApplicationResource.ActionListPaperDocs;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            string paperAccessToken = ApplicationResource.DefaultAccessToken;
            string memberId = string.Empty;

            docIds = new List<PaperListViewItemModel>();

            IDataResponse response = service.ListPaperDocs(new MemberData()
            {
                MemberId = memberId
            }, paperAccessToken);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (response.Data != null)
                {
                    string data = response.Data.ToString();
                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                    // clear existing data first
                    model.Paper.Clear();
                     
                    int resultCount = jsonData["doc_ids"].Count;
                    for (int i = 0; i < resultCount; i++)
                    {
                        dynamic paperDocId = jsonData["doc_ids"][i];

                        // update model
                        PaperListViewItemModel lvItem = new PaperListViewItemModel()
                        {
                            PaperId = paperDocId,
                            IsChecked = true
                        };
                        docIds.Add(lvItem);
                    }
                    //if the group count is above limit - default 1000 we need to grab the cursor and call continue
                    string cursor = jsonData["cursor"]["value"];
                    bool hasMore = jsonData["has_more"];
                    while (hasMore)
                    {
                        service.ListPaperDocsUrl = ApplicationResource.ActionListContinuationPaperDocs;
                        IDataResponse responseCont = service.ListPaperDocs(new MemberData()
                        {
                            Cursor = cursor
                        }, paperAccessToken);

                        string dataCont = responseCont.Data.ToString();
                        dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                        int resultContCount = jsonDataCont["doc_ids"].Count;
                        for (int i = 0; i < resultContCount; i++)
                        {
                            dynamic paperDocId = jsonDataCont["doc_ids"][i];
                            // update model
                            PaperListViewItemModel lvItem = new PaperListViewItemModel()
                            {
                                PaperId = paperDocId,
                                IsChecked = true
                            };
                            docIds.Add(lvItem);
                        }
                        hasMore = jsonDataCont["has_more"];
                        cursor = jsonDataCont["cursor"]["value"];
                    }
                }
            }
        }

        private void GetPaperMetadata(IPaperModel model, IMainPresenter presenter, string docId)
        {
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.GetPaperMetadataUrl = ApplicationResource.ActionGetPaperDocMetadata;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            string paperAccessToken = ApplicationResource.DefaultAccessToken;

            string memberId = string.Empty;

            IDataResponse response = service.GetPaperMetadata(docId, paperAccessToken, memberId);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (response.Data != null)
                {
                    string data = response.Data.ToString();
                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                    dynamic paperDocIdobj = jsonData["doc_id"];
                    dynamic ownerobj = jsonData["owner"];
                    dynamic paperNameobj = jsonData["title"];
                    dynamic createdDateobj = jsonData["created_date"];
                    dynamic statusobj = jsonData["status"][".tag"];
                    dynamic revisionobj = jsonData["revision"];
                    dynamic lastUpdatedDateobj = jsonData["last_updated_date"];
                    dynamic lastEditorobj = jsonData["last_editor"];
                    
                    string paperDocId = paperDocIdobj.Value as string;
                    string owner = ownerobj.Value as string;
                    string paperName = paperNameobj.Value as string;
                    DateTime createdDate = DateTime.MinValue;
                    if (createdDateobj != null)
                    {
                        createdDate = createdDateobj;
                    }
                    string status = statusobj.Value as string;
                    UInt64 revision = 0;
                    if (revisionobj != null)
                    {
                        revision = revisionobj;
                    }
                    DateTime lastUpdatedDate = DateTime.MinValue;
                    if (lastUpdatedDateobj != null)
                    {
                        lastUpdatedDate = lastUpdatedDateobj;
                    }
                    string lastEditor = lastEditorobj.Value as string;

                    // update model
                    PaperListViewItemModel lvItem = new PaperListViewItemModel()
                    {
                        PaperId = paperDocId,
                        Owner = owner,
                        PaperName = paperName,
                        CreatedDate = createdDate,
                        Status = status,
                        Revision = revision,
                        LastUpdatedDate = lastUpdatedDate,
                        LastEditor = lastEditor,
                        IsChecked = true
                    };
                    model.Paper.Add(lvItem);
                }
            }
        }

        private string CreateTeamFolder(IPaperModel model, string teamFolderName, IMainPresenter presenter)
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

        private string SetFolderStatus(IPaperModel model, string teamFolderId, bool activeSetting, IMainPresenter presenter)
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

        private string SetDefaultSyncSetting(IPaperModel model, string teamFolderId, bool syncSetting, IMainPresenter presenter)
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

        public bool LoadTeamFoldersInputFile(IPaperModel model, IMainPresenter presenter)
        {
            bool loaded = true;
            try
            {
                FileInfo fInfo = new FileInfo(model.TeamFoldersInputFilePath);
                if (fInfo.Exists)
                {
                    // try load.
                    model.Paper.Clear();
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
                                PaperListViewItemModel lvItem = new PaperListViewItemModel()
                                {
                                    PaperName = reader.GetField<string>(0),
                                    IsChecked = true
                                };
                                model.Paper.Add(lvItem);
                            }
                            catch
                            {
                                throw new InvalidDataException(ErrorMessages.INVALID_CSV_DATA);
                            }
                        }
                        if (model.Paper.Any())
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

        private void GetTeamFoldersPerms(IPaperModel model, IMainPresenter presenter)
        {
            //IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            //service.ExportGroupPermsUrl = ApplicationResource.ActionSharingListFolderMembers;
            //service.UserAgentVersion = ApplicationResource.UserAgent;
            //List<Tuple<string, string, string>> sharedFolders;
            ////Get team member id's for each checked email to remove in objectlistview
            //IList<TeamListViewItemModel> members = SearchOwners(model, presenter);
            //string memberId = string.Empty;
            //foreach (var memberitem in members)
            //{
            //    if (!string.IsNullOrEmpty(memberitem.TeamId))
            //    {
            //        memberId = memberitem.TeamId;
            //        sharedFolders = this.GetSharedFolders(memberId, model, presenter);

            //        foreach (var item in sharedFolders)
            //        {
            //            IDataResponse response = service.ExportGroupPerms(new MemberData()
            //            {
            //                MemberId = memberId
            //            }, item.Item1, ApplicationResource.DefaultAccessToken);

            //            if (response.StatusCode == HttpStatusCode.OK)
            //            {
            //                if (response.Data != null)
            //                {
            //                    string data = response.Data.ToString();
            //                    dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);
            //                    //users
            //                    int resultCount = jsonData["users"].Count;
            //                    for (int i = 0; i < resultCount; i++)
            //                    {
            //                        dynamic users = jsonData["users"][i];
            //                        dynamic type = Convert.ToString(users["access_type"][".tag"]);
            //                        dynamic accountId = Convert.ToString(users["user"]["account_id"]);
            //                        dynamic id = Convert.ToString(users["user"]["team_member_id"]);
            //                        dynamic sharedFolderId = item.Item1;
            //                        dynamic sharedFolderName = item.Item2;
            //                        dynamic path = item.Item3;

            //                        // update model
            //                        TeamFoldersPermsItemModel lvItem1 = new TeamFoldersPermsItemModel()
            //                        {
            //                            TeamFolderName = sharedFolderName,
            //                            TeamFolderPath = path,
            //                            TeamFolderMember = accountId,
            //                            TeamFolderMemberId = id,
            //                            AccessType = type,
            //                            MemberCount = "1"
            //                        };
            //                        bool contains = ((model.TeamFoldersPerms.Any(p => p.TeamFolderName == sharedFolderName)) && ((model.TeamFoldersPerms.Any(p => p.TeamFolderMemberId == id))));
            //                        if (!contains)
            //                        {
            //                            model.TeamFoldersPerms.Add(lvItem1);
            //                        } 
            //                    }
            //                    //groups
            //                    int groupCount = jsonData["groups"].Count;
            //                    for (int i = 0; i < groupCount; i++)
            //                    {
            //                        dynamic groups = jsonData["groups"][i];
            //                        dynamic groupName = Convert.ToString(groups["group"]["group_name"]);
            //                        dynamic groupId = Convert.ToString(groups["group"]["group_id"]);
            //                        dynamic accessType = Convert.ToString(groups["access_type"][".tag"]);
            //                        dynamic memberCount = Convert.ToString(groups["group"]["member_count"]);
            //                        dynamic sharedFolderId = item.Item1;
            //                        dynamic sharedFolderName = item.Item2;
            //                        dynamic path = item.Item3;

            //                        // update model
            //                        TeamFoldersPermsItemModel lvItem1 = new TeamFoldersPermsItemModel()
            //                        {
            //                            TeamFolderName = sharedFolderName,
            //                            TeamFolderPath = path,
            //                            TeamFolderMember = groupName,
            //                            TeamFolderMemberId = groupId,
            //                            AccessType = accessType,
            //                            MemberCount = memberCount
            //                        };
            //                        bool contains = ((model.TeamFoldersPerms.Any(p => p.TeamFolderName == sharedFolderName)) && ((model.TeamFoldersPerms.Any(p => p.TeamFolderMemberId == groupId))));
            //                        if (!contains)
            //                        {
            //                            model.TeamFoldersPerms.Add(lvItem1);
            //                        }
            //                    }
            //                    //if the group count is above limit - default 1000 we need to grab the cursor and call continue
            //                    string cursor = jsonData["cursor"];

            //                    while (!string.IsNullOrEmpty(cursor))
            //                    {
            //                        service.ExportGroupPermsUrl = ApplicationResource.ActionSharingListFolderMembersContinuation;
            //                        IDataResponse responseCont = service.ExportGroupPerms(new MemberData()
            //                        {
            //                            MemberId = memberId,
            //                            Cursor = cursor
            //                        }, item.Item1, model.AccessToken);

            //                        string dataCont = responseCont.Data.ToString();
            //                        dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

            //                        //users
            //                        int resultCountCont = jsonDataCont["users"].Count;
            //                        for (int i = 0; i < resultCountCont; i++)
            //                        {
            //                            dynamic users = jsonDataCont["users"][i];
            //                            dynamic type = Convert.ToString(users["access_type"][".tag"]);
            //                            dynamic accountId = Convert.ToString(users["user"]["account_id"]);
            //                            dynamic id = Convert.ToString(users["user"]["team_member_id"]);
            //                            dynamic sharedFolderId = item.Item1;
            //                            dynamic sharedFolderName = item.Item2;
            //                            dynamic path = item.Item3;

            //                            // update model
            //                            TeamFoldersPermsItemModel lvItem1 = new TeamFoldersPermsItemModel()
            //                            {
            //                                TeamFolderName = sharedFolderName,
            //                                TeamFolderPath = path,
            //                                TeamFolderMember = accountId,
            //                                TeamFolderMemberId = id,
            //                                AccessType = type,
            //                                MemberCount = "1"
            //                            };
            //                            bool contains = ((model.TeamFoldersPerms.Any(p => p.TeamFolderName == sharedFolderName)) && ((model.TeamFoldersPerms.Any(p => p.TeamFolderMemberId == id))));
            //                            if (!contains)
            //                            {
            //                                model.TeamFoldersPerms.Add(lvItem1);
            //                            }
            //                        }
            //                        //groups
            //                        int groupCountCont = jsonDataCont["groups"].Count;
            //                        for (int i = 0; i < groupCountCont; i++)
            //                        {
            //                            dynamic groups = jsonDataCont["groups"][i];
            //                            dynamic groupName = Convert.ToString(groups["group"]["group_name"]);
            //                            dynamic groupId = Convert.ToString(groups["group"]["group_id"]);
            //                            dynamic accessType = Convert.ToString(groups["access_type"][".tag"]);
            //                            dynamic memberCount = Convert.ToString(groups["group"]["member_count"]);
            //                            dynamic sharedFolderId = item.Item1;
            //                            dynamic sharedFolderName = item.Item2;
            //                            dynamic path = item.Item3;

            //                            // update model
            //                            TeamFoldersPermsItemModel lvItem1 = new TeamFoldersPermsItemModel()
            //                            {
            //                                TeamFolderName = sharedFolderName,
            //                                TeamFolderPath = path,
            //                                TeamFolderMember = groupName,
            //                                TeamFolderMemberId = groupId,
            //                                AccessType = accessType,
            //                                MemberCount = memberCount
            //                            };
            //                            bool contains = ((model.TeamFoldersPerms.Any(p => p.TeamFolderName == sharedFolderName)) && ((model.TeamFoldersPerms.Any(p => p.TeamFolderMemberId == groupId))));
            //                            if (!contains)
            //                            {
            //                                model.TeamFoldersPerms.Add(lvItem1);
            //                            }
            //                        }
            //                        cursor = jsonDataCont["cursor"];
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}     
        }

        #endregion REST Service

        #region Events

        private void OnCommandGetPaper(object sender, System.EventArgs e)
        {
            IPaperView view = base._view as IPaperView;
            IPaperModel model = base._model as IPaperModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }
            Thread getpaperdocs = new Thread(() => {
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
                    //get Paper Ids
                    this.GetPaperDocs(model, presenter);
                    
                    //clear to create new one with all metadata for each docId
                    //model.Paper.Clear();
                    //get metadata from ids
                    foreach (PaperListViewItemModel item in docIds)
                    {
                        this.GetPaperMetadata(model, presenter, item.PaperId);
                    }
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IPaperView, IPaperModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderPaperList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Paper doc list completed. Total Docs [" + model.Paper.Count.ToString() + "]");
                        }, null);
                    }
                }
            });
            getpaperdocs.Start();
        }

        private void OnCommandCreatePaper(object sender, System.EventArgs e)
        {
            IPaperView view = base._view as IPaperView;
            IPaperModel model = base._model as IPaperModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            string teamFolderName = view.PaperName;
            bool syncSetting = view.SyncSetting;
            bool multiCheck = view.MultiPaperCreateCheck();
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
                        
                        foreach (PaperListViewItemModel item in model.Paper)
                        {
                            response = this.CreateTeamFolder(model, item.PaperName, presenter);
                            teamFolderCount++;
                        }
                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate
                            {
                                // update result and update view.
                                PresenterBase.SetViewPropertiesFromModel<IPaperView, IPaperModel>(
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
                                PresenterBase.SetViewPropertiesFromModel<IPaperView, IPaperModel>(
                                    ref view, model
                                );
                                // update result and update view.
                                //view.RenderTeamFoldersList();
                                presenter.ActivateSpinner(false);
                                presenter.EnableControl(true);
                                presenter.UpdateProgressInfo("Completed. Total Paper docs: [" + teamFolderCount.ToString() + "]");
                            }, null);
                        }
                    }   
                }
            });
            createteamfolder.Start();
        }

        private void OnCommandSetPaperStatus(object sender, System.EventArgs e)
        {
            IPaperView view = base._view as IPaperView;
            IPaperModel model = base._model as IPaperModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            PaperModel paperModel = view.GetPaperIds();
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
                    foreach (PaperListViewItemModel lvItem in paperModel.Paper)
                    {
                        this.SetFolderStatus(model, lvItem.PaperId, activeSetting, presenter);
                    }
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IPaperView, IPaperModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderPaperList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Completed.");
                        }, null);
                    }
                }
            });
            setfolderstatus.Start();
        }

        private void OnCommandSetPaperSyncSetting(object sender, System.EventArgs e)
        {
            IPaperView view = base._view as IPaperView;
            IPaperModel model = base._model as IPaperModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            PaperModel teamModel = view.GetPaperIds();
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
                    foreach (PaperListViewItemModel lvItem in teamModel.Paper)
                    {
                        this.SetDefaultSyncSetting(model, lvItem.PaperId, syncSetting, presenter);
                    }
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IPaperView, IPaperModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderPaperList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            setfoldersyncsetting.Start();
        }

        private void OnCommandExportPaper(object sender, System.EventArgs e)
        {
            IPaperView view = base._view as IPaperView;
            IPaperModel model = base._model as IPaperModel;
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
                    this.GetPaperDocs(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            PresenterBase.SetViewPropertiesFromModel<IPaperView, IPaperModel>(
                                ref view, model
                            );
                            string sPath = string.Empty;

                            if (model.Paper.Count > 0)
                            {
                                //create CSV file in My Documents folder
                                sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PaperExport.csv";
                                CsvConfiguration config = new CsvConfiguration()
                                {
                                    HasHeaderRecord = true,
                                    Delimiter = ",",
                                    Encoding = System.Text.Encoding.UTF8
                                };
                                config.RegisterClassMap(new TeamFoldersHeaderMap());
                                int total = model.Paper.Count;
                                using (CsvWriter writer = new CsvWriter(new StreamWriter(sPath), config))
                                {
                                    writer.WriteHeader<TeamFoldersHeaderRecord>();
                                    int count = 0;
                                    foreach (var item in model.Paper)
                                    {
                                        writer.WriteField<string>(item.PaperName);
                                        writer.WriteField<string>(item.PaperId);
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
                            if (model.Paper.Count == 0)
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

        private void OnCommandExportPaperPerms(object sender, System.EventArgs e)
        {
            IPaperView view = base._view as IPaperView;
            IPaperModel model = base._model as IPaperModel;
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
                            PresenterBase.SetViewPropertiesFromModel<IPaperView, IPaperModel>(
                                ref view, model
                            );
                            string sPath = string.Empty;
                            if (model.Paper.Count > 0)
                            {
                                //create CSV file in My Documents folder
                                sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PaperPermsExport.csv";
                                CsvConfiguration config = new CsvConfiguration()
                                {
                                    HasHeaderRecord = true,
                                    Delimiter = ",",
                                    Encoding = System.Text.Encoding.UTF8
                                };
                                config.RegisterClassMap(new TeamFoldersMembersHeaderMap());
                                //perms
                                int total = model.Paper.Count;
                                using (CsvWriter writer = new CsvWriter(new StreamWriter(sPath), config))
                                {
                                    writer.WriteHeader<TeamFoldersMembersHeaderRecord>();
                                    int count = 0;
                                    foreach (var item in model.Paper)
                                    {
                                        //writer.WriteField<string>(item.TeamFolderName);
                                        //writer.WriteField<string>(item.TeamFolderPath);
                                        //writer.WriteField<string>(item.TeamFolderMember);
                                        //writer.WriteField<string>(item.TeamFolderMemberId);
                                        //writer.WriteField<string>(item.AccessType);
                                        //writer.WriteField<string>(item.MemberCount);
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
                            if (model.Paper.Count == 0)
                            {
                                presenter.UpdateProgressInfo("No Paper docs were available to export.");
                            }
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            exportteamfoldersperms.Start();
        }

        private void OnCommandLoadPaper(object sender, EventArgs e)
        {
            IPaperView view = base._view as IPaperView;
            IPaperModel model = base._model as IPaperModel;
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
                            view.RenderPaperList();
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
            IPaperView view = base._view as IPaperView;
            IPaperModel model = base._model as IPaperModel;
            PresenterBase.SetModelPropertiesFromView<IPaperModel, IPaperView>(
                ref model, view
            );
        }

        #endregion Events
    }
}