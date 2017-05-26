namespace DfBAdminToolkit.View
{
    using Model;
    using System;
    using System.Collections.Generic;

    public interface ITeamAuditingView
        : IView
    {
        event EventHandler CommandLoadTeamAuditing;

        string AccessToken { get; set; }

        void RefreshAccessToken();

        string TeamFolderName { get; set; }

        string TeamFolderId { get; set; }

        string TeamFoldersInputFilePath { get; set; }

        bool SyncSetting { get; set; }

        bool ActiveSetting { get; set; }

        string UserEmail { get; set; }

        void RenderTeamAuditingList();
    }
}