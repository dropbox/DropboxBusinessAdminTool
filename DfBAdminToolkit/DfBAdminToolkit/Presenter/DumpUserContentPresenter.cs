namespace DfBAdminToolkit.Presenter
{
    using DfBAdminToolkit.Common.Services;
    using DfBAdminToolkit.Common.Utils;
    using DfBAdminToolkit.Model;
    using DfBAdminToolkit.View;
    using Newtonsoft.Json;
    using System;
    using System.Net;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public class DumpUserContentPresenter
        : PresenterBase, IDumpUserContentPresenter
    {
        private static readonly string LIST_FILES = "List file(s)";

        public string[] ContextMenuItemText { get; set; }

        public DumpUserContentPresenter(IDumpUserContentModel model, IDumpUserContentView view)
            : base(model, view)
        {
        }

        protected override void Initialize()
        {
            // read data from model
            IDumpUserContentView view = base._view as IDumpUserContentView;
            IDumpUserContentModel model = base._model as IDumpUserContentModel;
            PresenterBase.SetViewPropertiesFromModel<IDumpUserContentView, IDumpUserContentModel>(
                ref view, model
            );

            ContextMenuItemText = new string[]
            {
                LIST_FILES
            };
            view.SetContextMenuItemText(ContextMenuItemText);
            SyncContext.Post(delegate
            {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents()
        {
            if (!IsViewEventsWired)
            {
                IDumpUserContentView view = base._view as IDumpUserContentView;
                view.DataChanged += OnDataChanged;
                view.CommandListMembers += OnCommandListMembers;
                view.CommandDumpFiles += OnCommandDumpFiles;
                view.CommandContextMenuClicked += OnCommandContextMenuClicked;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents()
        {
            if (IsViewEventsWired)
            {
                IDumpUserContentView view = base._view as IDumpUserContentView;
                view.DataChanged -= OnDataChanged;
                view.CommandListMembers -= OnCommandListMembers;
                view.CommandDumpFiles -= OnCommandDumpFiles;
                view.CommandContextMenuClicked -= OnCommandContextMenuClicked;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp()
        {
        }

        #region REST Service

        private bool SearchFiles(IMemberServices service, string teamId, string email, IDumpUserContentModel model)
        {
            bool filesAdded = false;
            try
            {
                service.ListFolderUrl = ApplicationResource.ActionListFolder;
                IDataResponse response = service.ListFolders(
                    new MemberData()
                    {
                        MemberId = teamId
                    }, model.UserAccessToken);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.Data != null)
                    {
                        string content = response.Data as string;
                        dynamic jsonDataSearch = JsonConvert.DeserializeObject<dynamic>(content);

                        int entryCount = 0;
                        if (jsonDataSearch["entries"] != null)
                        {
                            entryCount = jsonDataSearch["entries"].Count;
                        }
                        // remove existing file entries.
                        for (int i = model.MemberList.Count - 1; i >= 0; i--)
                        {
                            TeamListViewItemModel lvItem = model.MemberList[i];
                            if (lvItem.TeamId.Equals(teamId))
                            {
                                model.MemberList.RemoveAt(i);
                            }
                        }

                        for (int i = 0; i < entryCount; i++)
                        {
                            if (jsonDataSearch["entries"][i][".tag"].ToString().Equals("file"))
                            {
                                TeamListViewItemModel lvItem = new TeamListViewItemModel()
                                {
                                    Email = email,
                                    TeamId = teamId,
                                    FileName = jsonDataSearch["entries"][i]["name"].ToString(),
                                    FilePath = jsonDataSearch["entries"][i]["path_lower"].ToString(),
                                    FileSize = FileUtil.FormatFileSize(Convert.ToInt64(jsonDataSearch["entries"][i]["size"].ToString())),
                                    IsChecked = true
                                };
                                model.MemberList.Add(lvItem);
                            }
                        }
                        if (entryCount > 0)
                        {
                            filesAdded = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }
            return filesAdded;
        }

        private void SearchMembers(IDumpUserContentModel model)
        {
            if (!string.IsNullOrEmpty(model.UserAccessToken))
            {
                MemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                service.ListMembersUrl = ApplicationResource.ActionListMembers;
                IDataResponse response = service.ListMembers(new MemberData()
                {
                    SearchLimit = ApplicationResource.SearchDefaultLimit
                }, model.UserAccessToken);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.Data != null)
                    {
                        string data = response.Data.ToString();
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                        // clear existing data first
                        model.MemberList.Clear();

                        int resultCount = jsonData["members"].Count;
                        for (int i = 0; i < resultCount; i++)
                        {
                            dynamic idObj = jsonData["members"][i]["profile"]["team_member_id"];
                            dynamic emailObj = jsonData["members"][i]["profile"]["email"];
                            string teamId = idObj.Value as string;
                            string email = emailObj.Value as string;

                            // update model
                            TeamListViewItemModel lvItem = new TeamListViewItemModel()
                            {
                                Email = email,
                                TeamId = teamId
                            };

                            model.MemberList.Add(lvItem);
                        }
                        //if the memberID count is above limit - default 1000 we need to grab the cursor and call continue
                        bool hasMore = jsonData["has_more"];
                        string cursor = jsonData["cursor"];

                        while (hasMore)
                        {
                            service.ListMembersContinuationUrl = ApplicationResource.ActionListMembersContinuation;
                            IDataResponse responseCont = service.ListMembersContinuation(new MemberData()
                            {
                                Cursor = cursor
                            }, model.UserAccessToken);

                            string dataCont = responseCont.Data.ToString();
                            dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                            int resultContCount = jsonDataCont["members"].Count;
                            for (int i = 0; i < resultContCount; i++)
                            {
                                dynamic idObj = jsonDataCont["members"][i]["profile"]["team_member_id"];
                                dynamic emailObj = jsonDataCont["members"][i]["profile"]["email"];
                                string teamId = idObj.Value as string;
                                string email = emailObj.Value as string;

                                // update model
                                TeamListViewItemModel lvItem = new TeamListViewItemModel()
                                {
                                    Email = email,
                                    TeamId = teamId
                                };

                                model.MemberList.Add(lvItem);
                            }
                            hasMore = jsonDataCont["has_more"];
                            cursor = jsonDataCont["cursor"];
                        }
                    }
                }
            }
        }

        private void DumpFiles(IDumpUserContentModel model, IMainPresenter presenter)
        {
            if (SyncContext != null)
            {
                SyncContext.Post(delegate
                {
                    presenter.UpdateProgressInfo("Preparing Download...");
                }, null);
            }

            int counter = 0;
            int total = model.MemberList.Where(d => d.IsChecked && !string.IsNullOrEmpty(d.FileName)).ToList().Count;
            IMemberServices service = new MemberServices(ApplicationResource.ContentUrl, ApplicationResource.ApiVersion);
            service.FileDumpUrl = ApplicationResource.ActionFilesDownload;

            foreach (TeamListViewItemModel lvItem in model.MemberList)
            {
                if (lvItem.IsChecked && !string.IsNullOrEmpty(lvItem.FileName))
                {
                    // notify progress
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            presenter.UpdateProgressInfo(string.Format("Downloading File: {0}/{1}", ++counter, total));
                        }, null);
                    }

                    service.DumpFile(
                        new MemberData()
                        {
                            Email = lvItem.Email,
                            Path = lvItem.FilePath,
                            FileName = lvItem.FileName,
                            MemberId = lvItem.TeamId
                        },
                        model.OutputFolder,
                        model.UserAccessToken
                    );
                }
            }
        }

        #endregion REST Service

        #region Events

        private void OnDataChanged(object sender, EventArgs e)
        {
            IDumpUserContentView view = base._view as IDumpUserContentView;
            IDumpUserContentModel model = base._model as IDumpUserContentModel;
            PresenterBase.SetModelPropertiesFromView<IDumpUserContentModel, IDumpUserContentView>(
                ref model, view
            );
        }

        private void OnCommandContextMenuClicked(object sender, Common.DataExchange.DataUpdatedEventArgs e)
        {
            MenuItem selectedContextMenuItem = sender as MenuItem;
            if (selectedContextMenuItem != null)
            {
                if (selectedContextMenuItem.Text.ToLower().Equals(LIST_FILES, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (e.Data != null)
                    {
                        IDumpUserContentView view = base._view as IDumpUserContentView;
                        IDumpUserContentModel model = base._model as IDumpUserContentModel;
                        IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
                        ArrayList list = (ArrayList)e.Data;
                        IList<TeamListViewItemModel> selectedLvItems = list.Cast<TeamListViewItemModel>().ToList();
                        if (selectedLvItems != null && selectedLvItems.Count > 0)
                        {
                            // lock UI
                            if (SyncContext != null)
                            {
                                SyncContext.Post(delegate
                                {
                                    presenter.EnableControl(false);
                                    presenter.ActivateSpinner(true);
                                    presenter.UpdateProgressInfo("Preparing Search...");
                                }, null);
                            }

                            Thread search = new Thread(() =>
                            {
                                if (string.IsNullOrEmpty(model.UserAccessToken))
                                {
                                    SyncContext.Post(delegate
                                    {
                                        presenter.ShowErrorMessage(ErrorMessages.INVALID_TOKEN, ErrorMessages.DLG_DEFAULT_TITLE);
                                        presenter.UpdateProgressInfo("");
                                        presenter.ActivateSpinner(false);
                                        presenter.EnableControl(true);
                                    }, null);
                                }
                                else
                                {
                                    MemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                                    foreach (TeamListViewItemModel item in selectedLvItems)
                                    {
                                        SearchFiles(service, item.TeamId, item.Email, model);
                                        SyncContext.Post(delegate
                                        {
                                            presenter.UpdateProgressInfo(string.Format("Searching Files For : {0}", item.Email));
                                        }, null);
                                    }

                                    // complete.
                                    if (SyncContext != null)
                                    {
                                        SyncContext.Post(delegate
                                        {
                                            // update result and update view.
                                            PresenterBase.SetViewPropertiesFromModel<IDumpUserContentView, IDumpUserContentModel>(
                                                ref view, model
                                            );
                                            view.ShowGroups(true);
                                            view.RenderMembersFileSearchResult();
                                            view.EnableDumpControl(true);
                                            presenter.UpdateProgressInfo("Completed");
                                            presenter.ActivateSpinner(false);
                                            presenter.EnableControl(true);
                                        }, null);
                                    }
                                }
                            });
                            search.Start();
                        }
                    }
                }
            }
        }

        private void OnCommandDumpFiles(object sender, EventArgs e)
        {
            IDumpUserContentView view = base._view as IDumpUserContentView;
            IDumpUserContentModel model = base._model as IDumpUserContentModel;
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

            // TODO: to improve stability, we will need to ensure to kill
            // thread when user exits application while thread is running for REST service call
            Thread dumpFiles = new Thread(() =>
            {
                if (string.IsNullOrEmpty(model.UserAccessToken))
                {
                    SyncContext.Post(delegate
                    {
                        presenter.ShowErrorMessage(ErrorMessages.INVALID_TOKEN, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.UpdateProgressInfo("");
                        presenter.ActivateSpinner(false);
                        presenter.EnableControl(true);
                    }, null);
                }
                else if (string.IsNullOrEmpty(model.OutputFolder))
                {
                    SyncContext.Post(delegate
                    {
                        presenter.ShowErrorMessage(ErrorMessages.MISSING_OUTPUT_FOLDER, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.UpdateProgressInfo("");
                        presenter.ActivateSpinner(false);
                        presenter.EnableControl(true);
                    }, null);
                }
                else
                {
                    // perform search
                    this.DumpFiles(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            presenter.UpdateProgressInfo("Completed");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            dumpFiles.Start();
        }

        private void OnCommandListMembers(object sender, EventArgs e)
        {
            IDumpUserContentView view = base._view as IDumpUserContentView;
            IDumpUserContentModel model = base._model as IDumpUserContentModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            // notify view to mark start of process
            if (SyncContext != null)
            {
                SyncContext.Post(delegate
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }

            // TODO: to improve stability, we will need to ensure to kill
            // thread when user exits application while thread is running for REST service call
            Thread memberSearch = new Thread(() =>
            {
                if (string.IsNullOrEmpty(model.UserAccessToken))
                {
                    SyncContext.Post(delegate
                    {
                        presenter.ShowErrorMessage(ErrorMessages.INVALID_TOKEN, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.UpdateProgressInfo("");
                        presenter.ActivateSpinner(false);
                        presenter.EnableControl(true);
                    }, null);
                }
                else
                {
                    // perform search
                    this.SearchMembers(model);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IDumpUserContentView, IDumpUserContentModel>(
                                ref view, model
                            );
                            view.RenderMembersFileSearchResult();
                            if (model.MemberList.Count > 0)
                            {
                                view.LazyInitializeContextMenu();
                                view.EnableContextMenuItems(true);
                                //view.EnableDumpControl(true);
                            }
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

        #endregion Events
    }
}