namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public class TeamFoldersModel
       : ITeamFoldersModel {

        public string AccessToken { get; set; }

        public string TeamFoldersInputFilePath { get; set; }

        public List<TeamFoldersListViewItemModel> TeamFolders { get; set; }

        public TeamFoldersModel() {
            Initialize();
        }

        public void Initialize() {
            TeamFolders = new List<TeamFoldersListViewItemModel>();
            AccessToken = ApplicationResource.DefaultProvisionToken;
        }

        public void CleanUp() {
        }
    }
}