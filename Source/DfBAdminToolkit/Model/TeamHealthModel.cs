namespace DfBAdminToolkit.Model {

    using System;

    public class TeamHealthModel
       : ITeamHealthModel {

        public string AccessToken { get; set; }

        public DateTime RefreshDateTime { get; set; }

        //get_info
        public string TeamName { get; set; }

        public string LicensedUsers { get; set; }

        public string ProvisionedUsers { get; set; }

        //get_storage
        public string TotalUsage { get; set; }

        public string SharedUsage { get; set; }

        public string UnsharedUsage { get; set; }

        public string SharedFolders { get; set; }

        //get_activity
        public string ActiveSharedFolders7Day { get; set; }

        public string ActiveUsers7Day { get; set; }

        public string Adds { get; set; }

        public string Edits { get; set; }

        public string Deletes { get; set; }

        //get_devices
        public string windows { get; set; }

        public string macos { get; set; }

        public string linux { get; set; }

        public string ios { get; set; }

        public string android { get; set; }

        public string other { get; set; }

        public string total { get; set; }

        public TeamHealthModel() {
            Initialize();
        }

        public void Initialize() {
            AccessToken = ApplicationResource.DefaultAccessToken;
        }

        public void CleanUp() {
        }
    }
}