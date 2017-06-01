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
        public string ActiveSharedFolders28Day { get; set; }

        public string ActiveUsers28Day { get; set; }

        public string Adds { get; set; }

        public string Edits { get; set; }

        public string Deletes { get; set; }

        //get_devices
        public string ActiveDevices28Day { get; set; }

        public TeamHealthModel() {
            Initialize();
        }

        public void Initialize() {
            AccessToken = ApplicationResource.DefaultProvisionToken;
        }

        public void CleanUp() {
        }
    }
}