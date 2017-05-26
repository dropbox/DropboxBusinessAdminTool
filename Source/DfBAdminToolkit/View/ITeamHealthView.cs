namespace DfBAdminToolkit.View
{
    using Model;
    using System;
    using System.Collections.Generic;

    public interface ITeamHealthView
        : IView
    {
        event EventHandler CommandLoadTeamHealthFolders;

        string AccessToken { get; set; }

        void RefreshAccessToken();

        string TeamFolderName { get; set; }

        string TeamFolderId { get; set; }

        string TeamFoldersInputFilePath { get; set; }

        bool SyncSetting { get; set; }

        bool ActiveSetting { get; set; }

        string UserEmail { get; set; }

        void RenderTeamHealthList();
    }
}