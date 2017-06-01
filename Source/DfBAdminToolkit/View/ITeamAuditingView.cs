namespace DfBAdminToolkit.View
{
    using Model;
    using System;
    using System.Collections.Generic;

    public interface ITeamAuditingView
        : IView
    {
        event EventHandler CommandLoadTeamEvents;
        event EventHandler CommandLoadCSV;

        string AccessToken { get; set; }

        DateTime StartTime { get; set; }

        DateTime EndTime { get; set; }

        void RefreshAccessToken();

        string TeamHealthInputFilePath { get; set; }

        string EventCategory { get; set; }

        void RenderTeamAuditingList(List<TeamAuditingListViewItemModel> TeamAuditing);
    }
}