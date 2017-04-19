namespace DfBAdminToolkit.View
{
    using Model;
    using System;
    using System.Collections.Generic;

    public interface ITeamFoldersView
        : IView
    {
        event EventHandler CommandGetTeamFolders;
        event EventHandler CommandCreateTeamFolder;
        event EventHandler CommandSetFolderStatus;
        event EventHandler CommandSetFolderSyncSetting;
        event EventHandler CommandLoadTeamFolders;
        event EventHandler CommandExportTeamFolders;
        event EventHandler CommandExportTeamFoldersPerms;

        string AccessToken { get; set; }

        void RefreshAccessToken();

        bool MultiTeamFoldersCreateCheck();

        string TeamFolderName { get; set; }

        string TeamFolderId { get; set; }

        string TeamFoldersInputFilePath { get; set; }

        bool SyncSetting { get; set; }

        bool ActiveSetting { get; set; }

        string UserEmail { get; set; }

        void RenderTeamFoldersList();

        void RenderTeamFoldersListFromCSV(List<TeamFoldersListViewItemModel> teamFolders);

        TeamFoldersModel GetTeamFolderIds();
    }
}