namespace DfBAdminToolkit.View
{
    using Model;
    using System;
    using System.Collections.Generic;

    public interface ITeamAuditingView
        : IView
    {
        event EventHandler CommandLoadTeamEvents;

        string AccessToken { get; set; }

        DateTime StartTime { get; set; }

        DateTime EndTime { get; set; }

        void RefreshAccessToken();

        string TeamFolderName { get; set; }

        string TeamFolderId { get; set; }

        string TeamFoldersInputFilePath { get; set; }

        bool SyncSetting { get; set; }

        bool ActiveSetting { get; set; }

        string UserEmail { get; set; }

        void RenderTeamAuditingList(List<TeamAuditingListViewItemModel> TeamAuditing);
    }
}