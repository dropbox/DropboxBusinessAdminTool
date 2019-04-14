﻿namespace DfBAdminToolkit.Presenter
{
    using CsvHelper;
    using CsvHelper.Configuration;
    using Common.Services;
    using Common.Utils;
    using Model;
    using View;
    using Newtonsoft.Json;
    using System;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Collections.Generic;
    using System.Threading;

    public class ProvisioningPresenter
        : PresenterBase, IProvisioningPresenter {

        public ProvisioningPresenter(IProvisioningModel model, IProvisioningView view)
            : base(model, view) {
        }

        protected override void Initialize() {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            PresenterBase.SetViewPropertiesFromModel<IProvisioningView, IProvisioningModel>(
                ref view, model
            );

            SyncContext.Post(delegate {
                view.RefreshAccessToken();
            }, null);
        }

        protected override void WireViewEvents() {
            if (!IsViewEventsWired) {
                IProvisioningView view = base._view as IProvisioningView;
                view.DataChanged += OnDataChanged;
                view.CommandProvision += OnCommandProvision;
                view.CommandDeprovision += OnCommandDeprovision;
                view.CommandSuspend += OnCommandSuspend;
                view.CommandUnsuspend += OnCommandUnsuspend;
                view.CommandUpdateProfile += OnCommandUpdateProfile;
                view.CommandRecover += OnCommandRecover;
                view.CommandLoadInputFile += OnCommandLoadInputFile;
                view.CommandLoadUpdateInputFile += OnCommandLoadUpdateInputFile;
                view.CommandCreateCSV += OnCommandListMembersCreateCSV;
                view.CommandGetUsage += OnCommandGetUsage;       
                IsViewEventsWired = true;
            }
        }

        protected override void UnWireViewEvents() {
            if (IsViewEventsWired) {
                IProvisioningView view = base._view as IProvisioningView;
                view.DataChanged -= OnDataChanged;
                view.CommandProvision -= OnCommandProvision;
                view.CommandDeprovision -= OnCommandDeprovision;
                view.CommandSuspend -= OnCommandSuspend;
                view.CommandUnsuspend -= OnCommandUnsuspend;
                view.CommandUpdateProfile -= OnCommandUpdateProfile;
                view.CommandRecover -= OnCommandRecover;
                view.CommandLoadInputFile -= OnCommandLoadInputFile;
                view.CommandLoadUpdateInputFile -= OnCommandLoadUpdateInputFile;
                view.CommandCreateCSV -= OnCommandListMembersCreateCSV;
                view.CommandGetUsage -= OnCommandGetUsage;
                IsViewEventsWired = false;
            }
        }

        protected override void CleanUp() {
        }

        public bool LoadInputFile(IProvisioningModel model, IMainPresenter presenter)
        {
            bool loaded = true;
            try
            {
                FileInfo fInfo = new FileInfo(model.InputFilePath);
                if (fInfo.Exists) {
                    // try load.
                    model.Members.Clear();
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
                                    Email = reader.GetField<string>(0),
                                    FirstName = reader.GetField<string>(1),
                                    LastName = reader.GetField<string>(2),
                                    PersistentId = reader.GetField<string>(3),
                                    IsChecked = true
                                };
                                model.Members.Add(lvItem);
                            }
                            catch
                            {
                                throw new InvalidDataException(ErrorMessages.INVALID_CSV_DATA);
                            }
                        }
                        if (model.Members.Any())
                        {
                            loaded = true;
                        }
                    }
                } else {
                    throw new InvalidDataException(ErrorMessages.MISSING_CSV_FILE);
                }
            }
            catch (Exception)
            {
                // error message.
                SyncContext.Post(delegate 
                {
                    presenter.ShowErrorMessage(ErrorMessages.INVALID_CSV_DATA, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return loaded;
        }

        public bool LoadUpdateInputFile(IProvisioningModel model, IMainPresenter presenter)
        {
            bool loaded = true;
            try
            {
                FileInfo fInfo = new FileInfo(model.InputFilePath);
                if (fInfo.Exists)
                {
                    // try load.
                    model.Members.Clear();
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
                                    Email = reader.GetField<string>(0),
                                    NewEmail = reader.GetField<string>(1),
                                    NewExternalId = reader.GetField<string>(2),
                                    PersistentId = reader.GetField<string>(3),
                                    IsChecked = true
                                };
                                model.Members.Add(lvItem);
                            }
                            catch
                            {
                                throw new InvalidDataException(ErrorMessages.INVALID_CSV_DATA);
                            }
                        }
                        if (model.Members.Any())
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
            catch (Exception)
            {
                // error message.
                SyncContext.Post(delegate {
                    presenter.ShowErrorMessage(ErrorMessages.INVALID_CSV_DATA, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return loaded;
        }

        public void UpdateSettings()
        {
            OnDataChanged(this, new EventArgs());
        }

        #region REST Service

        private string ProvisionRoles(IProvisioningModel model, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.AddMemberUrl = ApplicationResource.ActionAddMember;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            try
            {
                foreach (MemberListViewItemModel item in model.Members.Where(m => m.IsChecked).ToList())
                {
                    IServiceResponse response = service.AddMember(new MemberData()
                    {
                        Email = item.Email,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        SendWelcomeEmail = model.SendWelcomeEmail,
                        ProvisionStatus = item.ProvisionStatus,
                        RoleName = model.SelectedRole,
                        PersistentId = item.PersistentId
                    }, model.AccessToken);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate
                            {
                                if (response.Message.Contains("success"))
                                {
                                    item.ProvisionStatus = "Provisioned successfully.";
                                    presenter.UpdateProgressInfo(string.Format("Added Member: {0}: {1} {2}", item.Email, item.FirstName, item.LastName));
                                }
                                if (response.Message.Contains("team_license_limit"))
                                {
                                    item.ProvisionStatus = "Team is already full.The organization has no available licenses.";
                                    presenter.UpdateProgressInfo("Team is already full. The organization has no available licenses.");
                                }
                                if (response.Message.Contains("free_team_member_limit_reached"))
                                {
                                    item.ProvisionStatus = "Team is already full. The free team member limit has been reached.";
                                    presenter.UpdateProgressInfo("Team is already full. The free team member limit has been reached.");
                                }
                                if (response.Message.Contains("user_already_on_team"))
                                {
                                    item.ProvisionStatus = "User is already on this team. The provided email address is associated with a user who is already a member of (including in recoverable state) or invited to the team.";
                                    presenter.UpdateProgressInfo("User is already on this team. The provided email address is associated with a user who is already a member of (including in recoverable state) or invited to the team.");
                                }
                                if (response.Message.Contains("user_on_another_team"))
                                {
                                    item.ProvisionStatus = "User is already on another team. The provided email address is associated with a user that is already a member or invited to another team.";
                                    presenter.UpdateProgressInfo("User is already on another team. The provided email address is associated with a user that is already a member or invited to another team.");
                                }
                                if (response.Message.Contains("user_already_paired"))
                                {
                                    item.ProvisionStatus = "User is already paired.";
                                    presenter.UpdateProgressInfo("User is already paired.");
                                }
                                if (response.Message.Contains("user_migration_failed"))
                                {
                                    item.ProvisionStatus = "User migration has failed.";
                                    presenter.UpdateProgressInfo("User migration has failed.");
                                }
                                if (response.Message.Contains("duplicate_external_member_id"))
                                {
                                    item.ProvisionStatus = "A user with the given external member ID already exists on the team (including in recoverable state).";
                                    presenter.UpdateProgressInfo("A user with the given external member ID already exists on the team (including in recoverable state).");
                                }
                                if (response.Message.Contains("user_creation_failed"))
                                {
                                    item.ProvisionStatus = "User creation has failed.";
                                    presenter.UpdateProgressInfo("User creation has failed.");
                                }
                            }, null);
                        }
                    }
                    else
                    {
                        item.ProvisionStatus = response.Message;
                        presenter.UpdateProgressInfo(response.Message);
                    }
                }
            }
            catch (Exception)
            {
                // error message.
                SyncContext.Post(delegate
                {
                    presenter.ShowErrorMessage(ErrorMessages.FAILED_TO_ADD_MEMBER, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return errorMessage;
        }

        private string DeprovisionRoles(IProvisioningModel model, IMainPresenter presenter)
        {
            string UserAccessToken = ApplicationResource.DefaultAccessToken;
            string errorMessage = string.Empty;
            //for removing members
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.RemoveMemberUrl = ApplicationResource.ActionRemoveMember;
            service.UserAgentVersion = ApplicationResource.UserAgent;

            //for removing shared folder members
            IMemberServices service2 = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service2.RemoveSharedFolderMemberUrl = ApplicationResource.ActionSharingRemoveFolderMember;
            service2.UserAgentVersion = ApplicationResource.UserAgent;

            try
            {  
                //now we can safely remove member
                foreach (MemberListViewItemModel item in model.Members.Where(m => m.IsChecked).ToList())
                {
                    //if Remove Sharing is checked let's do this first before deprovisioning
                    if (model.RemoveSharing)
                    {
                        //Get team member id's for each checked email to remove in objectlistview
                        IList<TeamListViewItemModel> members = SearchOwners(model, presenter);
                        string memberId = string.Empty;
                        foreach (var memberitem in members)
                        {
                            if (!string.IsNullOrEmpty(memberitem.TeamId))
                            {
                                if (item.Email == memberitem.Email)
                                {
                                    memberId = memberitem.TeamId;
                                }
                            }
                        }
                        //Next get folder list for shared folder id's and owner id's
                        List<Tuple<string, string>> sharedFolderInfo = GetSharedFolderOwnerInfo(memberId, model, presenter);
                    
                        foreach (var sharedItem in sharedFolderInfo)
                        {
                            //Last do a remove folder member for each collaborator we are going to remove member
                            IServiceResponse response2 = service2.RemoveSharedFolderMember(sharedItem.Item1, sharedItem.Item2, item.Email, UserAccessToken);

                            if (response2.StatusCode == HttpStatusCode.OK)
                            {
                                if (SyncContext != null)
                                {
                                    SyncContext.Post(delegate
                                    {
                                        presenter.UpdateProgressInfo(string.Format("Removed shared folder id: [" + sharedItem.Item2 + "] for [" + item.Email + "]"));
                                    }, null);
                                }
                            }
                            else
                            {
                                errorMessage = "Bad Request: " + response2.Message;
                            }
                        }
                    }
                    IServiceResponse response = service.RemoveMember(new MemberData()
                    {
                        Email = item.Email,
                        KeepAccount = model.KeepAccount,
                        ProvisionStatus = item.ProvisionStatus
                    }, model.AccessToken);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate
                            {
                                if (response.Message.Contains("complete"))
                                {
                                    item.ProvisionStatus = "Deprovisioned successfully.";
                                    presenter.UpdateProgressInfo(string.Format("Removed Member: {0}", item.Email));
                                }
                                if (response.Message.Contains("user_not_found"))
                                {
                                    item.ProvisionStatus = "No matching user found. The provided team_member_id, email, or external_id does not exist on this team.";
                                    presenter.UpdateProgressInfo("No matching user found.");
                                }
                                if (response.Message.Contains("user_not_in_team"))
                                {
                                    item.ProvisionStatus = "The user is not a member of the team.";
                                    presenter.UpdateProgressInfo(" The user is not a member of the team.");
                                }
                                if (response.Message.Contains("remove_last_admin"))
                                {
                                    item.ProvisionStatus = "The user is the last admin of the team, so it cannot be removed from it.";
                                    presenter.UpdateProgressInfo("The user is the last admin of the team, so it cannot be removed from it.");
                                }
                                if (response.Message.Contains("email_address_too_long_to_be_disabled"))
                                {
                                    item.ProvisionStatus = "The email address of the user is too long to be disabled.";
                                    presenter.UpdateProgressInfo("The email address of the user is too long to be disabled.");
                                }

                            }, null);
                        }
                    }
                    else
                    {
                        item.ProvisionStatus = response.Message;
                        presenter.UpdateProgressInfo(response.Message);
                    }
                }
            }
            catch (Exception)
            {
                // error message.
                SyncContext.Post(delegate
                {
                    presenter.ShowErrorMessage(ErrorMessages.FAILED_TO_REMOVE_MEMBER, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return errorMessage;
        }

        private string SuspendMember(IProvisioningModel model, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.SuspendMemberUrl = ApplicationResource.ActionSuspendMember;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            try
            {
                foreach (MemberListViewItemModel item in model.Members.Where(m => m.IsChecked).ToList())
                {
                    IServiceResponse response = service.SuspendMember(new MemberData()
                    {
                        Email = item.Email
                    }, model.AccessToken);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate
                            {
                                presenter.UpdateProgressInfo(string.Format("Suspended Member: {0}", item.Email));
                            }, null);
                        }
                    }
                    else
                    {
                        errorMessage = "Bad Request: " + response.Message;
                    }
                }
            }
            catch (Exception)
            {
                // error message.
                SyncContext.Post(delegate
                {
                    presenter.ShowErrorMessage(ErrorMessages.FAILED_TO_SUSPEND_MEMBER, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return errorMessage;
        }

        private string UnsuspendMember(IProvisioningModel model, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.UnSuspendMemberUrl = ApplicationResource.ActionUnsuspendMember;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            try
            {
                foreach (MemberListViewItemModel item in model.Members.Where(m => m.IsChecked).ToList())
                {
                    IServiceResponse response = service.UnSuspendMember(new MemberData()
                    {
                        Email = item.Email
                    }, model.AccessToken);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate
                            {
                                presenter.UpdateProgressInfo(string.Format("Unsuspended Member: {0}", item.Email));
                            }, null);
                        }
                    }
                    else
                    {
                        errorMessage = "Bad Request: " + response.Message;
                    }
                }
            }
            catch (Exception)
            {
                // error message.
                SyncContext.Post(delegate
                {
                    presenter.ShowErrorMessage(ErrorMessages.FAILED_TO_UNSUSPEND_MEMBER, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return errorMessage;
        }

        private string RecoverMember(IProvisioningModel model, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.RecoverMemberUrl = ApplicationResource.ActionRecoverMember;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            try
            {
                foreach (MemberListViewItemModel item in model.Members.Where(m => m.IsChecked).ToList())
                {
                    IServiceResponse response = service.RecoverMember(new MemberData()
                    {
                        Email = item.Email,
                        ProvisionStatus = item.ProvisionStatus
                    }, model.AccessToken);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate
                            {
                                if (response.Message == "null")
                                {
                                    item.ProvisionStatus = "Recovered successfully.";
                                    presenter.UpdateProgressInfo(string.Format("Recovered Member: {0}", item.Email));
                                }
                                if (response.Message.Contains("user_not_found"))
                                {
                                    item.ProvisionStatus = "No matching user found. The provided team_member_id, email, or external_id does not exist on this team.";
                                    presenter.UpdateProgressInfo("No matching user found.");
                                }
                                if (response.Message.Contains("user_unrecoverable"))
                                {
                                    item.ProvisionStatus = "The user is not recoverable.";
                                    presenter.UpdateProgressInfo("The user is not recoverable.");
                                }
                                if (response.Message.Contains("user_not_in_team"))
                                {
                                    item.ProvisionStatus = "The user is not a member of the team.";
                                    presenter.UpdateProgressInfo("The user is not a member of the team.");
                                }
                                if (response.Message.Contains("team_license_limit"))
                                {
                                    item.ProvisionStatus = "The organization has no available licenses.";
                                    presenter.UpdateProgressInfo("The organization has no available licenses.");
                                }

                            }, null);
                        }
                    }
                    else
                    {
                        item.ProvisionStatus = response.Message;
                        presenter.UpdateProgressInfo(response.Message);
                    }
                }
            }
            catch (Exception)
            {
                // error message.
                SyncContext.Post(delegate
                {
                    presenter.ShowErrorMessage(ErrorMessages.FAILED_TO_RECOVER_MEMBER, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return errorMessage;
        }

        private string UpdateProfile(IProvisioningModel model, IMainPresenter presenter)
        {
            string errorMessage = string.Empty;
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.SetProfileUrl = ApplicationResource.ActionSetProfile;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            try
            {
                foreach (MemberListViewItemModel item in model.Members.Where(m => m.IsChecked).ToList())
                {
                    IServiceResponse response = service.SetProfile(new MemberData()
                    {
                        Email = item.Email,
                        NewEmail = item.NewEmail,
                        NewExternalId = item.NewExternalId
                    }, model.AccessToken);
                    
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        if (SyncContext != null)
                        {
                            SyncContext.Post(delegate
                            {
                                presenter.UpdateProgressInfo(string.Format("Updated profile for: {0}", item.Email));
                            }, null);
                        }
                    }
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        if ((response.Message).Contains("user_not_found"))
                        {
                            errorMessage = ErrorMessages.USER_NOT_FOUND;
                        }
                        if ((response.Message).Contains("user_not_in_team"))
                        {
                            errorMessage = ErrorMessages.USER_NOT_IN_TEAM;
                        }
                        if ((response.Message).Contains("email_reserved_for_other_user"))
                        {
                            errorMessage = ErrorMessages.EMAIL_RESERVED;
                        }
                        if ((response.Message).Contains("set_profile_disallowed"))
                        {
                            errorMessage = ErrorMessages.SET_PROFILE_DISALLOWED;
                        }
                        if ((response.Message).Contains("external_id_used_by_other_user"))
                        {
                            errorMessage = ErrorMessages.EXTERNAL_ID_USED;
                        }
                        if ((response.Message).Contains("no_new_data_specified"))
                        {
                            errorMessage = ErrorMessages.NO_NEW_DATA_SPECIFIED;
                        }
                    } 
                    else
                    {
                        errorMessage = "Bad Request: " + response.Message;
                    }
                }
            }
            catch(Exception)
            {
                //just catch the exception and return error message
                SyncContext.Post(delegate {
                    presenter.ShowErrorMessage(ErrorMessages.FAILED_TO_UPDATE_PROFILE, ErrorMessages.DLG_DEFAULT_TITLE);
                    presenter.UpdateProgressInfo("");
                    presenter.ActivateSpinner(false);
                    presenter.EnableControl(true);
                }, null);
            }
            return errorMessage;
        }

        private void SearchMembersCreateCSV(IProvisioningModel model)
        {
            string UserAccessToken = ApplicationResource.DefaultAccessToken;
            if (!string.IsNullOrEmpty(UserAccessToken))
            {
                MemberServices serviceUsage = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                serviceUsage.GetUsageUrl = ApplicationResource.ActionGetUsage;
                List<string[]> members = new List<string[]>();

                MemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                service.ListMembersUrl = ApplicationResource.ActionListMembers;
                service.UserAgentVersion = ApplicationResource.UserAgent;
                IDataResponse response = service.ListMembers(new MemberData() {
                    SearchLimit = ApplicationResource.SearchDefaultLimit
                }, UserAccessToken);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.Data != null)
                    {
                        string data = response.Data.ToString();
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                        // clear existing data first
                        model.Members.Clear();

                        int resultCount = jsonData["members"].Count;
                        for (int i = 0; i < resultCount; i++)
                        {
                            dynamic emailObj = jsonData["members"][i]["profile"]["email"];
                            dynamic joinedOnObj = jsonData["members"][i]["profile"]["joined_on"];
                            dynamic teamIdObj = jsonData["members"][i]["profile"]["team_member_id"];
                            dynamic statusObj = jsonData["members"][i]["profile"]["status"][".tag"];
                            dynamic firstNameObj = jsonData["members"][i]["profile"]["name"]["given_name"];
                            dynamic lastNameObj = jsonData["members"][i]["profile"]["name"]["surname"];
                            dynamic roleObj = jsonData["members"][i]["role"][".tag"];
                            string role = roleObj.Value as string;
                            string email = emailObj.Value as string;
                            DateTime joinedOn = DateTime.MinValue;
                            if (joinedOnObj != null)
                            {
                                joinedOn = joinedOnObj;
                            }
                            string status = statusObj.Value as string;
                            string firstName = firstNameObj.Value as string;
                            string lastName = lastNameObj.Value as string;
                            string teamId = teamIdObj.Value as string;

                            IDataResponse responseUsage = serviceUsage.GetUsage(new MemberData()
                            {
                                MemberId = teamId
                            }, UserAccessToken);

                            UInt64 used = 0;

                            if (responseUsage.StatusCode == HttpStatusCode.OK)
                            {
                                if (responseUsage.Data != null)
                                {
                                    string dataUsage = responseUsage.Data.ToString();
                                    dynamic jsonDataUsage = JsonConvert.DeserializeObject<dynamic>(dataUsage);

                                    used = jsonDataUsage["used"];
                                }
                            }

                            // update model
                            MemberListViewItemModel lvItem = new MemberListViewItemModel()
                            {
                                Email = email,
                                FirstName = firstName,
                                LastName = lastName,
                                Status = status,
                                Role = role,
                                Usage = FileUtil.FormatFileSizeMB(used),
                                JoinedOn = joinedOn
                            };

                            model.Members.Add(lvItem);
                        }
                        //if the memberID count is above limit - default 1000 we need to grab the cursor and call continue
                        bool hasMore = jsonData["has_more"];
                        string cursor = jsonData["cursor"];

                        while (hasMore)
                        {
                            service.ListMembersContinuationUrl = ApplicationResource.ActionListMembersContinuation;
                            IDataResponse responseCont = service.ListMembersContinuation(new MemberData() {
                                Cursor = cursor
                            }, UserAccessToken);

                            string dataCont = responseCont.Data.ToString();
                            dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                            int resultContCount = jsonDataCont["members"].Count;
                            for (int i = 0; i < resultContCount; i++)
                            {
                                dynamic emailObj = jsonDataCont["members"][i]["profile"]["email"];
                                dynamic joinedOnObj = jsonData["members"][i]["profile"]["joined_on"];
                                dynamic teamIdObj = jsonDataCont["members"][i]["profile"]["team_member_id"];
                                dynamic statusObj = jsonDataCont["members"][i]["profile"]["status"][".tag"];
                                dynamic firstNameObj = jsonDataCont["members"][i]["profile"]["name"]["given_name"];
                                dynamic lastNameObj = jsonDataCont["members"][i]["profile"]["name"]["surname"];
                                dynamic roleObj = jsonDataCont["members"][i]["role"][".tag"];
                                string role = roleObj.Value as string;
                                string email = emailObj.Value as string;
                                DateTime joinedOn = DateTime.MinValue;
                                if (joinedOnObj != null)
                                {
                                    joinedOn = joinedOnObj;
                                }
                                string status = statusObj.Value as string;
                                string firstName = firstNameObj.Value as string;
                                string lastName = lastNameObj.Value as string;
                                string teamId = teamIdObj.Value as string;

                                IDataResponse responseUsage = serviceUsage.GetUsage(new MemberData()
                                {
                                    MemberId = teamId
                                }, UserAccessToken);

                                UInt64 used = 0;

                                if (responseUsage.StatusCode == HttpStatusCode.OK)
                                {
                                    if (responseUsage.Data != null)
                                    {
                                        string dataUsage = responseUsage.Data.ToString();
                                        dynamic jsonDataUsage = JsonConvert.DeserializeObject<dynamic>(dataUsage);

                                        used = jsonDataUsage["used"];
                                    }
                                }

                                // update model
                                MemberListViewItemModel lvItem = new MemberListViewItemModel() {
                                    Email = email,
                                    FirstName = firstName,
                                    LastName = lastName,
                                    Status = status,
                                    Role = role,
                                    Usage = FileUtil.FormatFileSizeMB(used),
                                    JoinedOn = joinedOn
                                };

                                model.Members.Add(lvItem);
                            }
                            hasMore = jsonDataCont["has_more"];
                            cursor = jsonDataCont["cursor"];
                        }
                    }
                }
            }
        }

        private void SearchMembersGetUsage(IProvisioningModel model)
        {
            string UserAccessToken = ApplicationResource.DefaultAccessToken;
            if (!string.IsNullOrEmpty(UserAccessToken))
            {
                MemberServices serviceUsage = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                serviceUsage.GetUsageUrl = ApplicationResource.ActionGetUsage;
                List<string[]> members = new List<string[]>();

                MemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
                service.ListMembersUrl = ApplicationResource.ActionListMembers;
                service.UserAgentVersion = ApplicationResource.UserAgent;
                IDataResponse response = service.ListMembers(new MemberData()
                {
                    SearchLimit = ApplicationResource.SearchDefaultLimit
                }, UserAccessToken);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.Data != null)
                    {
                        string data = response.Data.ToString();
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data);

                        // clear existing data first
                        model.Members.Clear();

                        int resultCount = jsonData["members"].Count;
                        for (int i = 0; i < resultCount; i++)
                        {
                            dynamic emailObj = jsonData["members"][i]["profile"]["email"];
                            dynamic firstNameObj = jsonData["members"][i]["profile"]["name"]["given_name"];
                            dynamic lastNameObj = jsonData["members"][i]["profile"]["name"]["surname"];
                            dynamic idObj = jsonData["members"][i]["profile"]["team_member_id"];
                            dynamic joinedOnObj = jsonData["members"][i]["profile"]["joined_on"];
                            dynamic statusObj = jsonData["members"][i]["profile"]["status"][".tag"];
                            string teamId = idObj.Value as string;
                            string email = emailObj.Value as string;
                            string firstName = firstNameObj.Value as string;
                            string lastName = lastNameObj.Value as string;
                            DateTime joinedOn = DateTime.MinValue;
                            if (joinedOnObj != null)
                            {
                                joinedOn = joinedOnObj;
                            }   
                            string status = statusObj.Value as string;

                            IDataResponse responseUsage = serviceUsage.GetUsage(new MemberData()
                            {
                                MemberId = teamId
                            }, UserAccessToken);

                            UInt64 used = 0;

                            if (responseUsage.StatusCode == HttpStatusCode.OK)
                            {
                                if (responseUsage.Data != null)
                                {
                                    string dataUsage = responseUsage.Data.ToString();
                                    dynamic jsonDataUsage = JsonConvert.DeserializeObject<dynamic>(dataUsage);

                                    used = jsonDataUsage["used"];
                                }
                            }

                            // update model
                            MemberListViewItemModel lvItem = new MemberListViewItemModel()
                            {
                                Email = email,
                                MemberId = teamId,
                                FirstName = firstName,
                                LastName = lastName,
                                Status = status,
                                Usage = FileUtil.FormatFileSizeMB(used),
                                JoinedOn = joinedOn
                            };

                            model.Members.Add(lvItem);
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
                            }, UserAccessToken);

                            string dataCont = responseCont.Data.ToString();
                            dynamic jsonDataCont = JsonConvert.DeserializeObject<dynamic>(dataCont);

                            int resultContCount = jsonDataCont["members"].Count;
                            for (int i = 0; i < resultContCount; i++)
                            {
                                dynamic emailObj = jsonDataCont["members"][i]["profile"]["email"];
                                dynamic firstNameObj = jsonDataCont["members"][i]["profile"]["name"]["given_name"];
                                dynamic lastNameObj = jsonDataCont["members"][i]["profile"]["name"]["surname"];
                                dynamic idObj = jsonData["members"][i]["profile"]["team_member_id"];
                                dynamic joinedOnObj = jsonData["members"][i]["profile"]["joined_on"];
                                dynamic statusObj = jsonDataCont["members"][i]["profile"]["status"][".tag"];
                                string teamId = idObj.Value as string;
                                string email = emailObj.Value as string;
                                string firstName = firstNameObj.Value as string;
                                string lastName = lastNameObj.Value as string;
                                DateTime joinedOn = DateTime.MinValue;
                                if (joinedOnObj != null)
                                {
                                    joinedOn = joinedOnObj;
                                }
                                string status = statusObj.Value as string;

                                IDataResponse responseUsage = serviceUsage.GetUsage(new MemberData()
                                {
                                    MemberId = teamId
                                }, UserAccessToken);

                                decimal used = 0;

                                if (responseUsage.StatusCode == HttpStatusCode.OK)
                                {
                                    if (responseUsage.Data != null)
                                    {
                                        string dataUsage = responseUsage.Data.ToString();
                                        dynamic jsonDataUsage = JsonConvert.DeserializeObject<dynamic>(dataUsage);

                                        used = jsonDataUsage["used"];
                                    }
                                }
                                // update model
                                MemberListViewItemModel lvItem = new MemberListViewItemModel()
                                {
                                    Email = email,
                                    MemberId = teamId,
                                    FirstName = firstName,
                                    LastName = lastName,
                                    Status = status,
                                    Usage = FileUtil.FormatFileSizeMB(used),
                                    JoinedOn = joinedOn
                                };
                                model.Members.Add(lvItem);
                            }
                            hasMore = jsonDataCont["has_more"];
                            cursor = jsonDataCont["cursor"];
                        }
                    }
                }
            }
        }

        public IList<TeamListViewItemModel> SearchOwners(IProvisioningModel model, IMainPresenter presenter)
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

        private List<Tuple<string, string>> GetSharedFolders(string memberId, IProvisioningModel model, IMainPresenter presenter)
        {
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.ListSharedFoldersUrl = ApplicationResource.ActionSharingListFolders;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            var sharedFolders = new List<Tuple<string, string>>();

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
                        dynamic isTeamFolder = Convert.ToBoolean(entries["is_team_folder"]);

                        var tuple = Tuple.Create(sharedFolderId, sharedFolderName);
                        if (!sharedFolders.Contains(tuple) && !isTeamFolder)
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

                            var tuple = Tuple.Create(sharedFolderId, sharedFolderName);
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

        private List<Tuple<string, string>> GetSharedFolderOwnerInfo(string memberId, IProvisioningModel model, IMainPresenter presenter)
        {
            IMemberServices service = new MemberServices(ApplicationResource.BaseUrl, ApplicationResource.ApiVersion);
            service.ExportGroupPermsUrl = ApplicationResource.ActionSharingListFolderMembers;
            service.UserAgentVersion = ApplicationResource.UserAgent;
            var sharedFolderInfo = new List<Tuple<string, string>>();

            List<Tuple<string, string>> sharedFolders = this.GetSharedFolders(memberId, model, presenter);
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
                        int resultCount = jsonData["users"].Count;
                        for (int i = 0; i < resultCount; i++)
                        {
                            dynamic users = jsonData["users"][i];
                            dynamic type = Convert.ToString(users["access_type"][".tag"]);
                            dynamic id = Convert.ToString(users["user"]["team_member_id"]);
                            dynamic sharedFolderId = item.Item1;

                            //we only need owner id
                            if (type == "owner")
                            {
                                // update list
                                var tuple = Tuple.Create(id, sharedFolderId);
                                sharedFolderInfo.Add(tuple);
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
                            int resultCountCont = jsonDataCont["users"].Count;
                            for (int i = 0; i < resultCountCont; i++)
                            {
                                dynamic users = jsonDataCont["users"][i];
                                dynamic type = Convert.ToString(users["access_type"][".tag"]);
                                dynamic id = Convert.ToString(users["user"]["team_member_id"]);
                                dynamic sharedFolderId = item.Item1;

                                //we only need owner id
                                if (type == "owner")
                                {
                                    // update list
                                    var tuple = Tuple.Create(id, sharedFolderId);
                                    sharedFolderInfo.Add(tuple);
                                }
                            }
                            cursor = jsonDataCont["cursor"];
                        }
                    }
                }
            }
            return sharedFolderInfo;
        }

        #endregion REST Service

        #region Events

        private void OnCommandLoadInputFile(object sender, EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null) {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Loading Input File...");
                }, null);
            }
            Thread load = new Thread(() => {
                if (!string.IsNullOrEmpty(model.AccessToken)) {
                    bool loaded = this.LoadInputFile(model, presenter);
                    if (SyncContext != null) {
                        SyncContext.Post(delegate {
                            // update result and update view.
                            view.RenderMemberList(model.Members);
                            presenter.UpdateProgressInfo("CSV Loaded");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            view.EnableProvisionButton(loaded);
                            view.EnableDeprovisionButton(loaded);
                            view.EnableSuspendButton(loaded);
                            view.EnableUnSuspendButton(loaded);
                        }, null);
                    }
                }
            });
            load.Start();
        }

        private void OnCommandLoadUpdateInputFile(object sender, EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Loading Input File...");
                }, null);
            }
            Thread load = new Thread(() => {
                if (!string.IsNullOrEmpty(model.AccessToken))
                {
                    bool loaded = this.LoadUpdateInputFile(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate {
                            // update result and update view.
                            view.RenderUpdateMemberList(model.Members);
                            presenter.UpdateProgressInfo("Update CSV Loaded");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                            view.EnableUpdateProfileButton(loaded);
                        }, null);
                    }
                }
            });
            load.Start();
        }

        private void OnCommandProvision(object sender, System.EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            if (SyncContext != null)
            {
                SyncContext.Post(delegate {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Processing...");
                }, null);
            }
            Thread provision = new Thread(() => 
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
                else if (string.IsNullOrEmpty(model.SelectedRole))
                {
                    SyncContext.Post(delegate 
                    {
                        presenter.ShowErrorMessage(ErrorMessages.MISSING_ROLE, ErrorMessages.DLG_DEFAULT_TITLE);
                        presenter.EnableControl(true);
                        presenter.ActivateSpinner(false);
                        presenter.UpdateProgressInfo("");
                    }, null);
                }
                else
                {
                    string error = ProvisionRoles(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            if (!string.IsNullOrEmpty(error)) {
                                presenter.ShowErrorMessage(error, ErrorMessages.DLG_DEFAULT_TITLE);
                                presenter.UpdateProgressInfo("");
                            }
                            else
                            {
                                presenter.UpdateProgressInfo("Provisioning completed.");
                                view.RenderProvisioningStatus(model.Members);
                                presenter.UpdateTitleBarStats();
                            }
                            // update result and update view.
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            provision.Start();
        }

        private void OnCommandDeprovision(object sender, System.EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
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
            Thread deprovision = new Thread(() => 
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
                    string error = DeprovisionRoles(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            if (!string.IsNullOrEmpty(error))
                            {
                                presenter.ShowErrorMessage(error, ErrorMessages.DLG_DEFAULT_TITLE);
                                presenter.UpdateProgressInfo("");
                            }
                            else
                            {
                                presenter.UpdateProgressInfo("Deprovisioning completed.");
                                view.RenderProvisioningStatus(model.Members);
                                presenter.UpdateTitleBarStats();
                            }
                            // update result and update view.
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            deprovision.Start();
        }

        private void OnCommandSuspend(object sender, System.EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
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
            Thread suspend = new Thread(() => 
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
                    string error = SuspendMember(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            if (!string.IsNullOrEmpty(error))
                            {
                                presenter.ShowErrorMessage(error, ErrorMessages.DLG_DEFAULT_TITLE);
                                presenter.UpdateProgressInfo("");
                            }
                            else
                            {
                                presenter.UpdateProgressInfo("Suspending members completed");
                            }
                            // update result and update view.
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            suspend.Start();
        }

        private void OnCommandUnsuspend(object sender, System.EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
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
            Thread unsuspend = new Thread(() => 
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
                    string error = UnsuspendMember(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            if (!string.IsNullOrEmpty(error))
                            {
                                presenter.ShowErrorMessage(error, ErrorMessages.DLG_DEFAULT_TITLE);
                                presenter.UpdateProgressInfo("");
                            }
                            else
                            {
                                presenter.UpdateProgressInfo("Unsuspending members completed");
                            }
                            // update result and update view.
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            unsuspend.Start();
        }

        private void OnCommandUpdateProfile(object sender, System.EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
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
            Thread unsuspend = new Thread(() =>
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
                    string error = UpdateProfile(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            if (!string.IsNullOrEmpty(error))
                            {
                                presenter.ShowErrorMessage(error, ErrorMessages.DLG_DEFAULT_TITLE);
                                presenter.UpdateProgressInfo("");
                            }
                            else
                            {
                                presenter.UpdateProgressInfo("Updating members profiles completed.");
                            }
                            // update result and update view.
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            unsuspend.Start();
        }

        private void OnCommandRecover(object sender, System.EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
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
            Thread recover = new Thread(() =>
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
                    string error = RecoverMember(model, presenter);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate
                        {
                            if (!string.IsNullOrEmpty(error))
                            {
                                presenter.ShowErrorMessage(error, ErrorMessages.DLG_DEFAULT_TITLE);
                                presenter.UpdateProgressInfo("");
                            }
                            else
                            {
                                presenter.UpdateProgressInfo("Recovering members completed.");
                                view.RenderProvisioningStatus(model.Members);
                                presenter.UpdateTitleBarStats();
                            }
                            // update result and update view.
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            recover.Start();
        }

        private void OnCommandListMembersCreateCSV(object sender, EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();

            // notify view to mark start of process
            if (SyncContext != null)
            {
                SyncContext.Post(delegate 
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Creating CSV file...");
                }, null);
            }
            Thread createCSV = new Thread(() => 
            {
                if (string.IsNullOrEmpty(ApplicationResource.DefaultAccessToken))
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
                    this.SearchMembersCreateCSV(model);
                    if (SyncContext != null)
                    {
                        SyncContext.Post(delegate 
                        {
                            // update result and update view.
                            PresenterBase.SetViewPropertiesFromModel<IProvisioningView, IProvisioningModel>(
                                ref view, model
                            );
                            string sPath = string.Empty;
                            if (model.Members.Count > 0)
                            {
                                //create CSV file in My Documents folder
                                sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DBMembers.csv";

                                StreamWriter SaveFile = new StreamWriter(sPath);
                                foreach (var item in model.Members)
                                {
                                    SaveFile.WriteLine(item.Email + "," + item.FirstName + "," + item.LastName + "," + item.Status + "," + item.Role + "," + item.Usage + "," + item.JoinedOn);
                                }
                                SaveFile.Close();
                            }
                            presenter.UpdateProgressInfo("Completed. Exported file located at " + sPath);
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            // start async search
            createCSV.Start();
        }

        private void OnCommandGetUsage(object sender, EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>();
            if (SyncContext != null)
            {
                SyncContext.Post(delegate 
                {
                    presenter.EnableControl(false);
                    presenter.ActivateSpinner(true);
                    presenter.UpdateProgressInfo("Gathering usage data...");
                }, null);
            }
            Thread getUsage = new Thread(() => 
            {
                if (!string.IsNullOrEmpty(model.AccessToken))
                {
                    if (SyncContext != null)
                    {
                        this.SearchMembersGetUsage(model);
                        SyncContext.Post(delegate 
                        {
                            // update result and update view.
                            view.RenderMemberList(model.Members);
                            presenter.UpdateProgressInfo("Completed.");
                            presenter.ActivateSpinner(false);
                            presenter.EnableControl(true);
                        }, null);
                    }
                }
            });
            getUsage.Start();
        }

        private void OnDataChanged(object sender, System.EventArgs e)
        {
            IProvisioningView view = base._view as IProvisioningView;
            IProvisioningModel model = base._model as IProvisioningModel;
            PresenterBase.SetModelPropertiesFromView<IProvisioningModel, IProvisioningView>(
                ref model, view
            );
        }

        #endregion Events
    }
}