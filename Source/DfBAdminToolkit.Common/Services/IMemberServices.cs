using System.Collections.Generic;

namespace DfBAdminToolkit.Common.Services
{
    public interface IMemberServices {

        #region Endpoint urls

        string AddMemberUrl { get; set; }

        string RemoveMemberUrl { get; set; }

        string SuspendMemberUrl { get; set; }

        string UnSuspendMemberUrl { get; set; }

        string ListMembersUrl { get; set; }

        string ListMembersContinuationUrl { get; set; }

        string SearchFilesUrl { get; set; }

        string ListFolderUrl { get; set; }

        string FileDumpUrl { get; set; }

        string GetDevicesUrl { get; set; }

        string DumpDevicesUrl { get; set; }

        string GetGroupsUrl { get; set; }

        string ExportGroupsUrl { get; set; }

        string ListSharedFoldersUrl { get; set; }

        string ListSharedFoldersContinuationUrl { get; set; }

        string ExportGroupPermsUrl { get; set; }

        string ExportGroupPermsContinuationUrl { get; set; }

        string CreateGroupUrl { get; set; }

        string AddMemberGroupUrl { get; set; }

        string DeleteMemberGroupUrl { get; set; }

        string GetUsageUrl { get; set; }

        string GetInfoUrl { get; set; }

        string SetProfileUrl { get; set; }

        string ActivateTeamFolderUrl { get; set; }

        string ArchiveTeamFolderUrl { get; set; }

        string SyncSettingTeamFolderUrl { get; set; }

        string CreateTeamFolderUrl { get; set; }

        string ListTeamFolderUrl { get; set; }

        string UpdateMembersTeamFolderUrl { get; set; }

        string UserAgentVersion { get; set; }

        #endregion Endpoint urls

        IServiceResponse AddMember(IMemberData data, string authToken);

        IServiceResponse RemoveMember(IMemberData data, string authToken);

        IServiceResponse SuspendMember(IMemberData data, string authToken);

        IServiceResponse UnSuspendMember(IMemberData data, string authToken);

        IDataResponse ListMembers(IMemberData data, string authToken);

        IDataResponse SearchFiles(IMemberData data, string authToken);

        IDataResponse ListFolders(IMemberData data, string authToken);

        IDataResponse GetUsage(IMemberData data, string authToken);

        IDataResponse GetInfo(string authToken);

        IServiceResponse SetProfile(IMemberData data, string authToken);

        IDataResponse GetGroups(IMemberData data, string authToken);

        IDataResponse ListSharedFolders(IMemberData data, string authToken);

        IDataResponse ExportGroups(IMemberData data, List<string> groupIds, string authToken);

        IDataResponse ExportGroupPerms(IMemberData data, string shareId, string authToken);

        IServiceResponse CreateGroup(string groupName, string groupType, string authToken);

        IServiceResponse AddMemberGroup(IMemberData data, string authToken);

        IServiceResponse DeleteMemberGroup(IMemberData data, string email, string authToken);

        IDataResponse DumpFile(IMemberData data, string outputFolder, string authToken);

        IDataResponse FindDevices(IMemberData data, string authToken);

        IDataResponse DumpDevices(IMemberData data, string authToken);

        IDataResponse ListTeamFolders(string authToken);

        IServiceResponse CreateTeamFolder(string teamFolderName, string authToken);

        IServiceResponse SetFolderStatus(string teamFolderId, bool activeSetting, string authToken);

        IServiceResponse SetFolderSyncSetting(string teamFolderId, string syncSetting, string authToken);
    }
}