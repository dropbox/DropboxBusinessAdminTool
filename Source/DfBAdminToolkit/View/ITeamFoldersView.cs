namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Model;
    using System;
    using System.Collections.Generic;

    public interface ITeamFoldersView
        : IView
    {
        event EventHandler CommandGetTeamFolders;
        event EventHandler CommandCreateTeamFolder;
        event EventHandler CommandSetFolderStatus;
        event EventHandler CommandSetFolderSyncSetting;

        string AccessToken { get; set; }

        void RefreshAccessToken();

        string TeamFolderName { get; set; }

        string TeamFolderId { get; set; }

        bool SyncSetting { get; set; }

        bool ActiveSetting { get; set; }

        string UserEmail { get; set; }

        void RenderTeamFoldersList();

        TeamFoldersModel GetTeamFolderIds();
    }
}