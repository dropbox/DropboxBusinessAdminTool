namespace DfBAdminToolkit.Presenter {

    using Common.Services;
    using Common.Utils;
    using CsvHelper;
    using CsvHelper.Configuration;
    using Model;
    using View;
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using System.Net;
    using System.Threading;
    using System.Collections.Generic;
    using System.IO;

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
                view.CommandExportGroups += OnCommandExportGroups;
                view.CommandExportGroupPerms += OnCommandExportGroupPerms;
                view.CommandAddMember += OnCommandAddMemberGroup;
                view.CommandDeleteMember += OnCommandDeleteMemberGroup;
                view.CommandLoadGroupsInputFile += OnCommandLoadGroupInputFile;
                view.CommandLoadGroupsMembersInputFile += OnCommandLoadGroupMemberInputFile;
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                IGroupsView view = base._view as IGroupsView;
                view.DataChanged -= OnDataChanged;
                view.CommandGetGroups -= OnCommandGetGroups;
                view.CommandCreateGroup -= OnCommandCreateGroup;
                view.CommandExportGroups -= OnCommandExportGroups;
                view.CommandExportGroupPerms -= OnCommandExportGroupPerms;
                view.CommandAddMember -= OnCommandAddMemberGroup;
                view.CommandDeleteMember -= OnCommandDeleteMemberGroup;
                view.CommandLoadGroupsInputFile -= OnCommandLoadGroupInputFile;
                view.CommandLoadGroupsMembersInputFile -= OnCommandLoadGroupMemberInputFile;
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

        private void ExportGroups(IGroupsModel model, IMainPresenter presenter)
        {
            IMemberServices service = service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.ExportGroupsUrl = ApplicationResource.ActionGetGroupInfo;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            List<string> groupIdList = new List<string>();

            foreach (GroupListViewItemModel item in model.Groups.Where(m => m.IsChecked).ToList())
            {
                groupIdList.Add(item.GroupId);
            }
            //if at least one is checked to export, lets do it
            if (groupIdList.Count > 0)
            {
                IDataResponse response = service.ExportGroups(new MemberData()
                {
                }, groupIdList, model.AccessToken);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.Data != null)
                    {
                        string data = response.Data.ToString();
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                        // clear existing data first
                        model.GroupInfo.Clear();
                        int resultCount = jsonData.Count;

                        for (int i = 0; i < resultCount; i++)
                        {
                            dynamic groupInfo = jsonData[i];
                            dynamic groupName = groupInfo["group_name"];
                            dynamic groupId = groupInfo["group_id"];
                            dynamic groupType = groupInfo["group_management_type"][".tag"];
                            dynamic teamMemberId = string.Empty;
                            dynamic email = string.Empty;
                            dynamic emailVerified = string.Empty;
                            dynamic status = string.Empty;
                            dynamic membershipType = string.Empty;
                            dynamic joinedOn = string.Empty;
                            dynamic accessType = string.Empty;
                            
                            //You can only get member profile info from user managed groups
                            if (groupType == "user_managed")
                            {
                                int memberCount = groupInfo["members"].Count;
                                for (int m = 0; m < memberCount; m++)
                                {
                                    teamMemberId = groupInfo["members"][m]["profile"]["team_member_id"];
                                    email = groupInfo["members"][m]["profile"]["email"];
                                    emailVerified = Convert.ToString(groupInfo["members"][m]["profile"]["email_verified"]);
                                    status = groupInfo["members"][m]["profile"]["status"][".tag"];
                                    membershipType = groupInfo["members"][m]["profile"]["membership_type"][".tag"];
                                    joinedOn = Convert.ToString(groupInfo["members"][m]["profile"]["joined_on"]);
                                    accessType = groupInfo["members"][m]["access_type"][".tag"];

                                    // update model
                                    GroupInfoItemModel lvItem1 = new GroupInfoItemModel()
                                    {
                                        GroupName = groupName,
                                        GroupId = groupId,
                                        GroupType = groupType,
                                        TeamMemberId = teamMemberId,
                                        Email = email,
                                        EmailVerified = emailVerified,
                                        Status = status,
                                        MembershipType = membershipType,
                                        JoinedOn = joinedOn,
                                        AccessType = accessType
                                    };
                                    model.GroupInfo.Add(lvItem1);
                                }
                            }
                            //if user managed group has no members we output 1 line for exported CSV so we can see group ID etc if needed
                            if (groupType == "user_managed" && groupInfo["members"].Count == 0)
                            {
                                // update model
                                GroupInfoItemModel lvItem2 = new GroupInfoItemModel()
                                {
                                    GroupName = groupName,
                                    GroupId = groupId,
                                    GroupType = groupType
                                };
                                model.GroupInfo.Add(lvItem2);
                            }
                            if (groupType != "user_managed")
                            {
                                // update model
                                GroupInfoItemModel lvItem = new GroupInfoItemModel()
                                {
                                    GroupName = groupName,
                                    GroupId = groupId,
                                    GroupType = groupType
                                };
                                model.GroupInfo.Add(lvItem);
                            }
                        }
                    }
                }
            }
        }

        private List<Tuple<string, string, string, string>> GetSharedFolders(IGroupsModel model, IMainPresenter presenter)
        {
            IMemberServices service = service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.ListSharedFoldersUrl = ApplicationResource.ActionSharingListFolders;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            var sharedFolders = new List<Tuple<string, string, string, string>>();
            string memberId = string.Empty;
            foreach (var item in model.GroupInfo)
            {
                if (!string.IsNullOrEmpty(item.TeamMemberId))
                {
                    memberId = item.TeamMemberId;
                    break;
                }
            }
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
                        dynamic sharedFolderId = Convert.ToString(entries["shared_folder_id"]);
                        dynamic sharedFolderName = Convert.ToString(entries["name"]);
                        dynamic isInsideTeamFolder = Convert.ToString(entries["is_inside_team_folder"]);
                        dynamic isTeamFolder = Convert.ToString(entries["is_team_folder"]);

                        var tuple = Tuple.Create(sharedFolderId,sharedFolderName, isInsideTeamFolder,isTeamFolder);
                        if (!sharedFolders.Contains(tuple))
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
                            dynamic sharedFolderId = Convert.ToString(entries["shared_folder_id"]);
                            dynamic sharedFolderName = Convert.ToString(entries["name"]);
                            dynamic isInsideTeamFolder = Convert.ToString(entries["is_inside_team_folder"]);
                            dynamic isTeamFolder = Convert.ToString(entries["is_team_folder"]);

                            var tuple = Tuple.Create(sharedFolderId, sharedFolderName, isInsideTeamFolder, isTeamFolder);
                            if (!sharedFolders.Contains(tuple))
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

        private void ExportGroupPerms(IGroupsModel model, IMainPresenter presenter)
        {
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.ExportGroupPermsUrl = ApplicationResource.ActionSharingListFolderMembers;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            string memberId = string.Empty;
            foreach (var item in model.GroupInfo)
            {
                if (!string.IsNullOrEmpty(item.TeamMemberId))
                {
                    memberId = item.TeamMemberId;
                    break;
                }
            }
            List<Tuple<string, string, string, string>> sharedFolders = this.GetSharedFolders(model, presenter);
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
                        int resultCount = jsonData["groups"].Count;
                        for (int i = 0; i < resultCount; i++)
                        {
                            dynamic groups = jsonData["groups"][i];
                            dynamic groupName = Convert.ToString(groups["group"]["group_name"]);
                            dynamic groupId = Convert.ToString(groups["group"]["group_id"]);
                            dynamic groupMgmtType = Convert.ToString(groups["group"]["group_management_type"][".tag"]);
                            dynamic groupType = Convert.ToString(groups["group"]["group_type"][".tag"]);
                            dynamic isMember = Convert.ToString(groups["group"]["is_member"]);
                            dynamic isOwner = Convert.ToString(groups["group"]["is_owner"]);
                            dynamic accessType = Convert.ToString(groups["access_type"][".tag"]);
                            dynamic isInherited = Convert.ToString(groups["is_inherited"]);
                            dynamic sharedFolderId = item.Item1;
                            dynamic sharedFolderName = item.Item2;  
                            dynamic isInsideTeamFolder = item.Item3;
                            dynamic isTeamFolder = item.Item4;
                   
                            // update model
                            GroupPermsItemModel lvItem = new GroupPermsItemModel()
                            {
                                GroupName = groupName,
                                GroupId = groupId,
                                GroupManagementType = groupMgmtType,
                                GroupType = groupType,
                                IsMember = isMember,
                                IsOwner = isOwner,
                                AccessType = accessType,
                                SharedFolderName = sharedFolderName,
                                SharedFolderId = sharedFolderId,
                                IsInherited = isInherited,
                                IsTeamFolder = isTeamFolder,
                                IsInsideTeamFolder = isInsideTeamFolder
                            };
                            model.GroupPerms.Add(lvItem);
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
                            int resultCountCont = jsonDataCont["groups"].Count;
                            for (int i = 0; i < resultCountCont; i++)
                            {
                                dynamic groups = jsonDataCont["groups"][i];
                                dynamic groupName = Convert.ToString(groups["group"]["group_name"]);
                                dynamic groupId = Convert.ToString(groups["group"]["group_id"]);
                                dynamic groupMgmtType = Convert.ToString(groups["group"]["group_management_type"][".tag"]);
                                dynamic groupType = Convert.ToString(groups["group"]["group_type"][".tag"]);
                                dynamic isMember = Convert.ToString(groups["group"]["is_member"]);
                                dynamic isOwner = Convert.ToString(groups["group"]["is_owner"]);
                                dynamic accessType = Convert.ToString(groups["access_type"][".tag"]);
                                dynamic isInherited = Convert.ToString(groups["is_inherited"]);
                                dynamic sharedFolderId = item.Item1;
                                dynamic sharedFolderName = item.Item2;
                                dynamic isInsideTeamFolder = item.Item3;
                                dynamic isTeamFolder = item.Item4;

                                // update model
                                GroupPermsItemModel lvItem = new GroupPermsItemModel()
                                {
                                    GroupName = groupName,
                                    GroupId = groupId,
                                    GroupManagementType = groupMgmtType,
                                    GroupType = groupType,
                                    IsMember = isMember,
                                    IsOwner = isOwner,
                                    AccessType = accessType,
                                    SharedFolderName = sharedFolderName,
                                    SharedFolderId = sharedFolderId,
                                    IsInherited = isInherited,
                                    IsTeamFolder = isTeamFolder,
                                    IsInsideTeamFolder = isInsideTeamFolder
                                };
                                model.GroupPerms.Add(lvItem);
                            }
                            cursor = jsonDataCont["cursor"];
                        }
                    }
                }
            }
        }

        private string CreateGroup(IGroupsModel model, string groupName, string groupType, bool multiCheck, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.CreateGroupUrl = ApplicationResource.ActionCreateGroup;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            string newGroupName = string.Empty;
            string newGroupType = string.Empty;

            if (!multiCheck)
            {
                IServiceResponse response = null;
                response = service.CreateGroup(groupName, groupType, model.AccessToken);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (SyncContext != null)
                    {
                        if (response.Message.Contains("group_management_type"))
                        {
                            SyncContext.Post(delegate
                            {
                                errorMessage = "Successful";
                                presenter.UpdateProgressInfo(string.Format("Created group [" + groupName + "]"));
                            }, null);
                        }
                    }
                }
                else
                {
                    if (response.Message.Contains("group_name_already_used"))
                    {
                        SyncContext.Post(delegate
                        {
                            if (response.Message.Contains("group_name_already_used"))
                            {
                                errorMessage = ErrorMessages.FAILED_TO_CREATE_GROUP_GROUP_EXISTS;
                                presenter.UpdateProgressInfo(ErrorMessages.FAILED_TO_CREATE_GROUP_GROUP_EXISTS);
                            }
                            if (response.Message.Contains("group_name_invalid"))
                            {
                                errorMessage = ErrorMessages.FAILED_TO_CREATE_GROUP_GROUP_INVALID;
                                presenter.UpdateProgressInfo(ErrorMessages.FAILED_TO_CREATE_GROUP_GROUP_INVALID);
                            }
                        }, null);
                    }
                }
                return errorMessage;
            }
            if (multiCheck)
            {
                IServiceResponse response = null;
                foreach (GroupListViewItemModel item in model.Groups)
                {
                    response = service.CreateGroup(item.GroupName, item.GroupType, model.AccessToken);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        if (SyncContext != null)
                        {
                            if (response.Message.Contains("group_management_type"))
                            {
                                SyncContext.Post(delegate
                                {
                                    item.AddStatus = "Successful";
                                    presenter.UpdateProgressInfo(string.Format("Created group [" + groupName + "]"));
                                }, null);
                            }
                        }
                    }
                    else
                    {
                        SyncContext.Post(delegate
                        {
                            if (response.Message.Contains("group_name_already_used"))
                            {
                                item.AddStatus = ErrorMessages.FAILED_TO_CREATE_GROUP_GROUP_EXISTS;
                                presenter.UpdateProgressInfo(ErrorMessages.FAILED_TO_CREATE_GROUP_GROUP_EXISTS);
                            }
                            if (response.Message.Contains("group_name_invalid"))
                            {
                                item.AddStatus = ErrorMessages.FAILED_TO_CREATE_GROUP_GROUP_INVALID;
                                presenter.UpdateProgressInfo(ErrorMessages.FAILED_TO_CREATE_GROUP_GROUP_INVALID);
                            }
                            else
                            {
                                item.AddStatus = response.Message;
                                presenter.UpdateProgressInfo(response.Message);
                            }
                        }, null);
                    }
                }      
            }
            return errorMessage;
        }

        private string AddMemberGroup(IGroupsModel model, string email, bool multiCheck, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.AddMemberGroupUrl = ApplicationResource.ActionAddMemberGroup;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            foreach (GroupListViewItemModel item in model.Groups.Where(m => m.IsChecked).ToList())
            {
                string newEmail = string.Empty;
                if (multiCheck)
                {
                    newEmail = item.Email;
                }
                if (!multiCheck)
                {
                    newEmail = email;
                }
                IServiceResponse response = service.AddMemberGroup(new MemberData()
                {
                    GroupId = item.GroupId,
                    GroupName = item.GroupName,
                    GroupEmail = newEmail   
                }, model.AccessToken);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            if (response.Message.Contains("group_management_type"))
                            {
                                item.AddStatus = "Successful.";
                                presenter.UpdateProgressInfo(string.Format("Added user [" + item.Email + "] to group [" + item.GroupName + "]"));
                            }
                        }, null);
                    }
                }
                else
                {
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            if (response.Message.Contains("group_not_found"))
                            {
                                item.AddStatus = ErrorMessages.FAILED_TO_ADD_MEMBER_TO_GROUP_NOT_FOUND;
                                presenter.UpdateProgressInfo(ErrorMessages.FAILED_TO_ADD_MEMBER_TO_GROUP_NOT_FOUND);
                            }
                            if (response.Message.Contains("duplicate_user"))
                            {
                                item.AddStatus = ErrorMessages.FAILED_TO_ADD_MEMBER_TO_GROUP_NOT_DUPLICATE;
                                presenter.UpdateProgressInfo(ErrorMessages.FAILED_TO_ADD_MEMBER_TO_GROUP_NOT_DUPLICATE);
                            }
                            else
                            {
                                item.AddStatus = response.Message;
                                presenter.UpdateProgressInfo(response.Message);
                            }
                        }, null);
                    }
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

        public bool LoadGroupInputFile(IGroupsModel model, IMainPresenter presenter)
        {
            bool loaded = true;
            try
            {
                FileInfo fInfo = new FileInfo(model.GroupInputFilePath);
                if (fInfo.Exists)
                {
                    // try load.
                    model.Groups.Clear();
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
                                GroupListViewItemModel lvItem = new GroupListViewItemModel()
                                {
                                    GroupName = reader.GetField<string>(0),
                                    GroupType = reader.GetField<string>(1),
                                    IsChecked = true
                                };
                                model.Groups.Add(lvItem);
                            }
                            catch
                            {
                                throw new InvalidDataException(ErrorMessages.INVALID_CSV_DATA);
                            }
                        }
                        if (model.Groups.Any())
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

        public bool LoadGroupMemberInputFile(IGroupsModel model, IMainPresenter presenter)
        {
            bool loaded = true;
            try
            {
                FileInfo fInfo = new FileInfo(model.GroupMemberInputFilePath);
                if (fInfo.Exists)
                {
                    // try load.
                    model.Groups.Clear();
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
                                GroupListViewItemModel lvItem = new GroupListViewItemModel()
                                {
                                    GroupName = reader.GetField<string>(0),
                                    GroupId = reader.GetField<string>(1),
                                    Email = reader.GetField<string>(2),
                                    IsChecked = true
                                };
                                model.Groups.Add(lvItem);
                            }
                            catch
                            {
                                throw new InvalidDataException(ErrorMessages.INVALID_CSV_DATA);
                            }
                        }
                        if (model.Groups.Any())
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
                            view.RenderGroupList(model.Groups);
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Group list completed.");
                        }, null);
                    }
                }
            });
            getgroups.Start();
        }

        private void OnCommandExportGroups(object sender, System.EventArgs e)
        {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }
            Thread exportgroups = new Thread(() => {
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
                    this.ExportGroups(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IGroupsView, IGroupsModel>(
                                ref view, model
                            );
                            string sPath = string.Empty;
                            
                            if (model.GroupInfo.Count > 0)
                            {
                                //create CSV file in My Documents folder
                                sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GroupInfoExport.csv";
                                CsvConfiguration config = new CsvConfiguration()
                                {
                                    HasHeaderRecord = true,
                                    Delimiter = ",",
                                    Encoding = System.Text.Encoding.UTF8
                                };
                                config.RegisterClassMap(new GroupInfoHeaderMap());
                                int total = model.GroupInfo.Count;
                                using (CsvWriter writer = new CsvWriter(new StreamWriter(sPath), config))
                                {
                                    writer.WriteHeader<GroupInfoHeaderRecord>();
                                    int count = 0;
                                    foreach (var item in model.GroupInfo)
                                    {
                                        writer.WriteField<string>(item.GroupName);
                                        writer.WriteField<string>(item.GroupId);
                                        writer.WriteField<string>(item.GroupType);
                                        writer.WriteField<string>(!string.IsNullOrEmpty(item.TeamMemberId) ? item.TeamMemberId : "");
                                        writer.WriteField<string>(!string.IsNullOrEmpty(item.Email) ? item.Email : "");
                                        writer.WriteField<string>(!string.IsNullOrEmpty(item.EmailVerified) ? item.EmailVerified : "");
                                        writer.WriteField<string>(!string.IsNullOrEmpty(item.Status) ? item.Status : "");
                                        writer.WriteField<string>(!string.IsNullOrEmpty(item.MembershipType) ? item.MembershipType : "");
                                        writer.WriteField<string>(!string.IsNullOrEmpty(item.JoinedOn) ? item.JoinedOn : "");
                                        writer.WriteField<string>(!string.IsNullOrEmpty(item.AccessType) ? item.AccessType : "");
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
                            if (model.GroupInfo.Count == 0)
                            {
                                presenter.UpdateProgressInfo("No groups were chosen to export.");
                            }
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            exportgroups.Start();
        }
        //need work
        private void OnCommandExportGroupPerms(object sender, System.EventArgs e)
        {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }
            Thread exportgroupperms = new Thread(() => {
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
                    //need to get groups checked then get shared folders for each
                    this.ExportGroups(model, presenter);
                    this.ExportGroupPerms(model, presenter);

                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IGroupsView, IGroupsModel>(
                                ref view, model
                            );
                            string sPath = string.Empty;
                            if (model.GroupPerms.Count > 0)
                            {
                                //create CSV file in My Documents folder
                                sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GroupPermsExport.csv";
                                CsvConfiguration config = new CsvConfiguration()
                                {
                                    HasHeaderRecord = true,
                                    Delimiter = ",",
                                    Encoding = System.Text.Encoding.UTF8
                                };
                                config.RegisterClassMap(new GroupPermsHeaderMap());
                                int total = model.GroupPerms.Count;
                                using (CsvWriter writer = new CsvWriter(new StreamWriter(sPath), config))
                                {
                                    writer.WriteHeader<GroupPermsHeaderRecord>();
                                    int count = 0;
                                    foreach (var item in model.GroupPerms)
                                    {       
                                        writer.WriteField<string>(item.GroupName);
                                        writer.WriteField<string>(item.GroupId);
                                        writer.WriteField<string>(item.GroupManagementType);
                                        writer.WriteField<string>(item.GroupType);
                                        writer.WriteField<string>(item.SharedFolderName);
                                        writer.WriteField<string>(item.SharedFolderId);
                                        writer.WriteField<string>(item.IsMember);
                                        writer.WriteField<string>(item.IsOwner);
                                        writer.WriteField<string>(item.AccessType);
                                        writer.WriteField<string>(item.IsInherited);
                                        writer.WriteField<string>(item.IsTeamFolder);
                                        writer.WriteField<string>(item.IsInsideTeamFolder);
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
                            if (model.GroupPerms.Count == 0)
                            {
                                presenter.UpdateProgressInfo("No groups were selected to export.");
                            }
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            exportgroupperms.Start();
        }

        private void OnCommandCreateGroup(object sender, System.EventArgs e)
        {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            string groupName = view.GroupName;
            string groupType = view.GroupType;
            bool multiCheck = view.MultiGroupCreateCheck();
            int groupCount = 0;

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
                    if (!multiCheck)
                    {
                        this.CreateGroup(model, groupName, groupType, false, presenter);
                        groupCount++;
                    }
                    if (multiCheck)
                    {
                        this.CreateGroup(model, string.Empty, string.Empty, true, presenter);
                        groupCount++;
                    }
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IGroupsView, IGroupsModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderGroupsStatus(model.Groups);
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Completed. Groups created [" + groupCount + "]");
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
            bool multiCheck = view.MultiGroupMemberCreateCheck();

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
                    if (!multiCheck)
                    {
                        if (email.Contains(","))
                        {
                            char delimiter = ',';
                            string[] emails = email.Split(delimiter);
                            foreach (string newEmail in emails)
                            {
                                this.AddMemberGroup(model, newEmail, false, presenter);
                            }
                        }
                        if (!email.Contains(","))
                        {
                            this.AddMemberGroup(model, email, false, presenter);
                        }
                    }
                    if (multiCheck)
                    {
                        this.AddMemberGroup(model, string.Empty, true, presenter);
                    }    
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IGroupsView, IGroupsModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderGroupsStatus(model.Groups);
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
            bool multiCheck = view.MultiGroupMemberCreateCheck();

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
                    if (email.Contains(","))
                    {
                        char delimiter = ',';
                        string[] emails = email.Split(delimiter);
                        foreach (string newEmail in emails)
                        {
                            this.DeleteMemberGroup(model, newEmail, presenter);
                        }
                    }
                    if (!email.Contains(","))
                    {
                        this.DeleteMemberGroup(model, email, presenter);
                    }  
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IGroupsView, IGroupsModel>(
                                ref view, model
                            );
                            // update result and update view.
                            view.RenderGroupsStatus(model.Groups);
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            presenter.UpdateProgressInfo("Completed.");
                        }, null);
                    }
                }
            });
            deletemembergroup.Start();
        }

        private void OnCommandLoadGroupInputFile(object sender, EventArgs e)
        {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Loading groups input File...");
                }, null);
            }
            Thread groupsLoad = new Thread(() => {
                if (!string.IsNullOrEmpty(model.AccessToken))
                {
                    bool loaded = this.LoadGroupInputFile(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate {
                            // update result and update view.
                            view.RenderGroupList(model.Groups);
                            presenter.UpdateProgressInfo("Groups CSV Loaded");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            groupsLoad.Start();
        }

        private void OnCommandLoadGroupMemberInputFile(object sender, EventArgs e)
        {
            IGroupsView view = base._view as IGroupsView;
            IGroupsModel model = base._model as IGroupsModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Loading group members input File...");
                }, null);
            }
            Thread groupMembersLoad = new Thread(() => {
                if (!string.IsNullOrEmpty(model.AccessToken))
                {
                    bool loaded = this.LoadGroupMemberInputFile(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate {
                            // update result and update view.
                            view.RenderGroupList(model.Groups);
                            presenter.UpdateProgressInfo("Group members CSV Loaded");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            groupMembersLoad.Start();
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