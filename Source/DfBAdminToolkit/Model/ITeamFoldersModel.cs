namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public interface ITeamFoldersModel
        : IModel {

        string AccessToken { get; set; }

        string TeamFoldersInputFilePath { get; set; }

        List<TeamFoldersListViewItemModel> TeamFolders { get; set; }

        List<TeamFoldersPermsItemModel> TeamFoldersPerms { get; set; }
    }
}