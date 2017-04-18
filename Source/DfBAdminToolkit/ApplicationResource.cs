namespace DfBAdminToolkit
{

    using System;
    using System.Configuration;
    using System.Threading;
    using Common.Extensions;

    public static class ApplicationResource
    {

        public static string BaseUrl
        {
            get { return ConfigurationManager.AppSettings.Get("BaseUrl"); }
        }

        public static string ContentUrl
        {
            get { return ConfigurationManager.AppSettings.Get("ContentUrl"); }
        }

        public static string ApiVersion
        {
            get { return ConfigurationManager.AppSettings.Get("ApiVersion"); }
        }

        public static string ActionListMembers
        {
            get { return ConfigurationManager.AppSettings.Get("ActionListMembers"); }
        }

        public static string ActionListMembersContinuation
        {
            get { return ConfigurationManager.AppSettings.Get("ActionListMembersContinuation"); }
        }

        public static string ActionFileSearch
        {
            get { return ConfigurationManager.AppSettings.Get("ActionFileSearch"); }
        }

        public static string ActionListFolder
        {
            get { return ConfigurationManager.AppSettings.Get("ActionListFolder"); }
        }

        public static string ActionListFolderContinuation
        {
            get { return ConfigurationManager.AppSettings.Get("ActionListFolderContinuation"); }
        }

        public static string ActionSharingListFolders
        {
            get { return ConfigurationManager.AppSettings.Get("ActionSharingListFolders"); }
        }

        public static string ActionSharingListFoldersContinuation
        {
            get { return ConfigurationManager.AppSettings.Get("ActionSharingListFoldersContinuation"); }
        }

        public static string ActionSharingListFolderMembers
        {
            get { return ConfigurationManager.AppSettings.Get("ActionSharingListFolderMembers"); }
        }

        public static string ActionSharingRemoveFolderMember
        {
            get { return ConfigurationManager.AppSettings.Get("ActionSharingRemoveFolderMember"); }
        }

        public static string ActionSharingListFolderMembersContinuation
        {
            get { return ConfigurationManager.AppSettings.Get("ActionSharingListFolderMembersContinuation"); }
        }

        public static string ActionGetGroups
        {
            get { return ConfigurationManager.AppSettings.Get("ActionGetGroups"); }
        }

        public static string ActionGetGroupsContinuation
        {
            get { return ConfigurationManager.AppSettings.Get("ActionGetGroupsContinuation"); }
        }

        public static string ActionCreateGroup
        {
            get { return ConfigurationManager.AppSettings.Get("ActionCreateGroup"); }
        }

        public static string ActionAddMemberGroup
        {
            get { return ConfigurationManager.AppSettings.Get("ActionAddMemberGroup"); }
        }

        public static string ActionDeleteMemberGroup
        {
            get { return ConfigurationManager.AppSettings.Get("ActionDeleteMemberGroup"); }
        }

        public static string ActionGetGroupInfo
        {
            get { return ConfigurationManager.AppSettings.Get("ActionGetGroupInfo"); }
        }

        public static string ActionFilesDownload {
            get { return ConfigurationManager.AppSettings.Get("ActionFilesDownload"); }
        }

        public static string ActionAddMember {
            get { return ConfigurationManager.AppSettings.Get("ActionAddMember"); }
        }

        public static string ActionRemoveMember {
            get { return ConfigurationManager.AppSettings.Get("ActionRemoveMember"); }
        }

        public static string ActionSuspendMember
        {
            get { return ConfigurationManager.AppSettings.Get("ActionSuspendMember"); }
        }

        public static string ActionUnsuspendMember
        {
            get { return ConfigurationManager.AppSettings.Get("ActionUnsuspendMember"); }
        }

        public static string ActionListTeamDevices {
            get { return ConfigurationManager.AppSettings.Get("ActionListTeamDevices"); }
        }

        public static string ActionDumpDevices {
            get { return ConfigurationManager.AppSettings.Get("ActionDumpDevices"); }
        }

        public static string ActionGetUsage
        {
            get { return ConfigurationManager.AppSettings.Get("ActionGetUsage"); }
        }

        public static string ActionGetInfo
        {
            get { return ConfigurationManager.AppSettings.Get("ActionGetInfo"); }
        }

        public static string ActionSetProfile
        {
            get { return ConfigurationManager.AppSettings.Get("ActionSetProfile"); }
        }

        public static string ActionActivateTeamFolder
        {
            get { return ConfigurationManager.AppSettings.Get("ActionActivateTeamFolder"); }
        }

        public static string ActionArchiveTeamFolder
        {
            get { return ConfigurationManager.AppSettings.Get("ActionArchiveTeamFolder"); }
        }

        public static string ActionUpdateDefaultSyncSettingTeamFolder
        {
            get { return ConfigurationManager.AppSettings.Get("ActionUpdateDefaultSyncSettingTeamFolder"); }
        }

        public static string ActionCreateTeamFolder
        {
            get { return ConfigurationManager.AppSettings.Get("ActionCreateTeamFolder"); }
        }

        public static string ActionListTeamFolder
        {
            get { return ConfigurationManager.AppSettings.Get("ActionListTeamFolder"); }
        }

        public static string ActionUpdateMembersTeamFolder
        {
            get { return ConfigurationManager.AppSettings.Get("ActionUpdateMembersTeamFolder"); }
        }

        public static int SearchDefaultLimit
        {
            get {
                int limit = 1000;
                int.TryParse(ConfigurationManager.AppSettings.Get("SearchDefaultLimit"), out limit);
                return limit;
            }
        }

        public static int SearchFileCountLimit
        {
            get {
                int limit = 65536;
                int.TryParse(ConfigurationManager.AppSettings.Get("SearchFileCountLimit"), out limit);
                return limit;
            }
        }

        public static bool SuppressFilenamesInStatus
        {
            get {
                bool status = false;
                bool.TryParse(ConfigurationManager.AppSettings.Get("SuppressFilenamesInStatus"), out status);
                return status;
            }
        }

        public static string RegistryEntryPoint
        {
            get { return ConfigurationManager.AppSettings.Get("RegistryEntryPoint"); }
        }

        public static string RegistryKey
        {
            get { return ConfigurationManager.AppSettings.Get("RegistryKey"); }
        }

        public static string DefaultAccessToken
        {
            get
            {
                string defaultToken = ConfigurationManager.AppSettings.Get("DefaultAccessToken");
                if (defaultToken.StartsWith("encrypted-"))
                {
                    defaultToken = defaultToken.Decrypt();
                }
                return defaultToken;
            }
        }

        public static string DefaultProvisionToken
        {
            get
            {
                string defaultProvisionToken = ConfigurationManager.AppSettings.Get("DefaultProvisionToken");
                if (defaultProvisionToken.StartsWith("encrypted-"))
                {
                    defaultProvisionToken = defaultProvisionToken.Decrypt();
                }
                return defaultProvisionToken;
            }
        }

        public static string DefaultOutputReportFilePrefix
        {
            get { return ConfigurationManager.AppSettings.Get("DefaultOutputReportFilePrefix"); }
        }

        public static string UserAgent
        {
            get
            {
                bool architecture = Environment.Is64BitOperatingSystem;
                string locale = Thread.CurrentThread.CurrentCulture.ToString();
                string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                string archOS = "i32";
                if (architecture)
                {
                    archOS = "i64";
                }
                return @"DropboxBusinessAdminToolkit/" + version + " (" + Environment.OSVersion.ToString() + "; " + archOS + "; " + locale + "; )";
            }
        }
    }
}