namespace DfBAdminToolkit {

    using System.Configuration;

    public static class ApplicationResource {

        public static string BaseUrl {
            get { return ConfigurationManager.AppSettings.Get("BaseUrl"); }
        }

        public static string ContentUrl {
            get { return ConfigurationManager.AppSettings.Get("ContentUrl"); }
        }

        public static string ApiVersion {
            get { return ConfigurationManager.AppSettings.Get("ApiVersion"); }
        }

        public static string ActionListMembers {
            get { return ConfigurationManager.AppSettings.Get("ActionListMembers"); }
        }

        public static string ActionListMembersContinuation {
            get { return ConfigurationManager.AppSettings.Get("ActionListMembersContinuation"); }
        }

        public static string ActionFileSearch {
            get { return ConfigurationManager.AppSettings.Get("ActionFileSearch"); }
        }

        public static string ActionListFolder {
            get { return ConfigurationManager.AppSettings.Get("ActionListFolder"); }
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

        public static string ActionListTeamDevices {
            get { return ConfigurationManager.AppSettings.Get("ActionListTeamDevices"); }
        }

        public static string ActionDumpDevices {
            get { return ConfigurationManager.AppSettings.Get("ActionDumpDevices"); }
        }

        public static int SearchDefaultLimit {
            get {
                int limit = 1000;
                int.TryParse(ConfigurationManager.AppSettings.Get("SearchDefaultLimit"), out limit);
                return limit;
            }
        }

        public static int SearchFileCountLimit {
            get {
                int limit = 65536;
                int.TryParse(ConfigurationManager.AppSettings.Get("SearchFileCountLimit"), out limit);
                return limit;
            }
        }

        public static string RegistryEntryPoint {
            get { return ConfigurationManager.AppSettings.Get("RegistryEntryPoint"); }
        }

        public static string RegistryKey {
            get { return ConfigurationManager.AppSettings.Get("RegistryKey"); }
        }

        public static string DefaultAccessToken {
            get { return ConfigurationManager.AppSettings.Get("DefaultAccessToken"); }
        }

        public static string DefaultProvisionToken {
            get { return ConfigurationManager.AppSettings.Get("DefaultProvisionToken"); }
        }

        public static string DefaultOutputReportFilePrefix {
            get { return ConfigurationManager.AppSettings.Get("DefaultOutputReportFilePrefix"); }
        }
    }
}