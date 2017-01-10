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

    public class GroupsPresenter
        : PresenterBase, IGroupsPresenter {

        public GroupsPresenter(IGroupsModel model, IGroupsView view)
            : base(model, view) {
        }

        protected override void Initialize() {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            PresenterBase.SetViewPropertiesFromModel<IGroupsView, IGroupsModel>(
                ref view, model
            );

            SyncContext.Post(delegate {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                IGroupsView view = base._view as IGroupsView;
                view.DataChanged += OnDataChanged;
                view.CommandGetGroups += OnCommandGetGroups;
                view.CommandCreateGroup += OnCommandCreateGroup;
                view.CommandAddMember += OnCommandAddMemberGroup;
                view.CommandDeleteMember += OnCommandDeleteMemberGroup;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                IGroupsView view = base._view as IGroupsView;
                view.DataChanged -= OnDataChanged;
                view.CommandGetGroups -= OnCommandGetGroups;
                view.CommandCreateGroup -= OnCommandCreateGroup;
                view.CommandAddMember -= OnCommandAddMemberGroup;
                view.CommandDeleteMember -= OnCommandDeleteMemberGroup;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp() {
        }

        public void UpdateSettings() {
            OnDataChanged(this, new EventArgs());
        }

        #region REST Service

        private void GetGroups(IGroupsModel model, IMainPresenter presenter)
        {
            IMemberServices service = service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.GetGroupsUrl = ApplicationResource.ActionGetGroups;
            service.UserAgentVersion = ApplicationResource.UserAgent;
                IDataResponse response = service.GetGroups(new MemberData()
                {
                }, model.AccessToken);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.Data != null)
                    {
                        string data = response.Data.ToString();
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                        // clear existing data first
                        model.Groups.Clear();
                        int resultCount = jsonData["groups"].Count;
                        for (int i = 0; i < resultCount; i++)
                        {
                            dynamic groups = jsonData["groups"][i];
                            dynamic groupName = groups["group_name"];
                            dynamic groupType = groups["group_management_type"][".tag"];
                            dynamic groupId = groups["group_id"];
                            dynamic memberCount = groups["member_count"];

                            // update model
                            GroupListViewItemModel lvItem = new GroupListViewItemModel()
                            {
                                GroupName = groupName,
                                GroupType = groupType,
                                GroupId = groupId,
                                MemberCount = memberCount
                            };

                            model.Groups.Add(lvItem);
                        }
                        //if the group count is above limit - default 1000 we need to grab the cursor and call continue
                        bool hasMore = jsonData["has_more"];
                        string cursor = jsonData["cursor"];

                        while (hasMore)
                        {
                            service.GetGroupsUrl = ApplicationResource.ActionGetGroupsContinuation;
                            IDataResponse responseCont = service.GetGroups(new MemberData()
                            {
                                Cursor = cursor
                            }, model.AccessToken);

                            string dataCont = responseCont.Data.ToString();
                            dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                            int resultContCount = jsonDataCont["groups"].Count;
                            for (int i = 0; i < resultContCount; i++)
                            {
                                dynamic groups = jsonDataCont["groups"][i];
                                dynamic groupName = groups["group_name"];
                                dynamic groupType = groups["group_management_type"][".tag"];
                                dynamic groupId = groups["group_id"];
                                dynamic memberCount = groups["member_count"];

                                // update model
                                GroupListViewItemModel lvItem = new GroupListViewItemModel()
                                {
                                    GroupName = groupName,
                                    GroupType = groupType,
                                    GroupId = groupId,
                                    MemberCount = memberCount
                                };

                                model.Groups.Add(lvItem);
                            }
                            hasMore = jsonDataCont["has_more"];
                            cursor = jsonDataCont["cursor"];
                        }
                    }
                }
        }

        private string CreateGroup(IGroupsModel model, string groupName, string groupType, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.CreateGroupUrl = ApplicationResource.ActionCreateGroup;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            IServiceResponse response = service.CreateGroup(groupName, groupType, model.AccessToken);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate {
                        presenter.UpdateProgressInfo(string.Format("Created group [" + groupName + "]"));
                    }, null);
                }
            }
            if (response.Message.Contains("group_name_already_used"))
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate {
                        presenter.UpdateProgressInfo(ErrorMessages.FAILED_TO_CREATE_GROUP_GROUP_EXISTS);
                    }, null);
                }
            }
            if (response.Message.Contains("group_name_invalid"))
            {
                if (SyncContext != null)
                {
                    SyncContext.Post(delegate {
                        presenter.UpdateProgressInfo(ErrorMessages.FAILED_TO_CREATE_GROUP_GROUP_INVALID);
                    }, null);
                }
            }
            else
            {
                errorMessage = ErrorMessages.FAILED_TO_CREATE_GROUP;
            }
            return errorMessage;
        }

        private string AddMemberGroup(IGroupsModel model, string email, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.AddMemberGroupUrl = ApplicationResource.ActionAddMemberGroup;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            foreach (GroupListViewItemModel item in model.Groups.Where(m => m.IsChecked).ToList())
            {
                IServiceResponse response = service.AddMemberGroup(new MemberData()
                {
                    GroupId = item.GroupId,
                    GroupName = item.GroupName   
                }, email, model.AccessToken);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            presenter.UpdateProgressInfo(string.Format("Added user [" + email + "] to group [" + item.GroupName + "]"));
                        }, null);
                    }
                }
                else
                {
                    errorMessage = ErrorMessages.FAILED_TO_ADD_MEMBER_TO_GROUP;
                }
            }
            return errorMessage;
        }

        private string DeleteMemberGroup(IGroupsModel model, string email, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.DeleteMemberGroupUrl = ApplicationResource.ActionDeleteMemberGroup;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            foreach (GroupListViewItemModel item in model.Groups.Where(m => m.IsChecked).ToList())
            {
                IServiceResponse response = service.DeleteMemberGroup(new MemberData()
                {
                    GroupId = item.GroupId,
                    GroupName = item.GroupName
                }, email, model.AccessToken);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            presenter.UpdateProgressInfo(string.Format("Deleted user [" + email + "] from group [" + item.GroupName + "]"));
                        }, null);
                    }
                }
                else
                {
                    errorMessage = ErrorMessages.FAILED_TO_DELETE_MEMBER_FROM_GROUP;
                }
            }
            return errorMessage;
        }

        #endregion REST Service

        #region Events

        private void OnCommandGetGroups(object sender, System.EventArgs e) {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }
            Thread getgroups = new Thread(() => {
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
                    this.GetGroups(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IGroupsView, IGroupsModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderGroupList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Group list completed.");
                        }, null);
                    }
                }
            });
            getgroups.Start();
        }

        private void OnCommandCreateGroup(object sender, System.EventArgs e)
        {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            string groupName = view.GroupName;
            string groupType = view.GroupType;

            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");

                }, null);
            }
            Thread creategroup = new Thread(() => {
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
                    this.CreateGroup(model, groupName, groupType, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IGroupsView, IGroupsModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderGroupList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            creategroup.Start();
        }

        private void OnCommandAddMemberGroup(object sender, System.EventArgs e)
        {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            string email = view.UserEmail;

            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                    
                }, null);
            }
            Thread addmembergroup = new Thread(() => {
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
                    this.AddMemberGroup(model, email, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IGroupsView, IGroupsModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderGroupList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Completed.");
                        }, null);
                    }
                }
            });
            addmembergroup.Start();
        }

        private void OnCommandDeleteMemberGroup(object sender, System.EventArgs e)
        {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            string email = view.UserEmail;

            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing..."); 
                }, null);
            }
            Thread deletemembergroup = new Thread(() => {
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
                    this.DeleteMemberGroup(model, email, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IGroupsView, IGroupsModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderGroupList();
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Completed.");
                        }, null);
                    }
                }
            });
            deletemembergroup.Start();
        }

        private void OnDataChanged(object sender, System.EventArgs e) {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            PresenterBase.SetModelPropertiesFromView<IGroupsModel, IGroupsView>(
                ref model, view
            );
        }

        #endregion Events
    }
}