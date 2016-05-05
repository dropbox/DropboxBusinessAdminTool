namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Common.DataExchange;
    using DfBAdminToolkit.Model;
    using System;
    using System.Collections.Generic;

    public interface IDumpUserContentView
        : IView
    {
        event EventHandler CommandListMembers;
        event EventHandler CommandDumpFiles;
        event EventHandler<DataUpdatedEventArgs> CommandContextMenuClicked;

        string UserAccessToken { get; set; }

        List<TeamListViewItemModel> MemberList { get; set; }

        string OutputFolder { get; set; }

        string[] ContextMenuItemText { get; set; }

        void RefreshAccessToken();

        void RenderMembersSearchResult();

        void RenderMembersFileSearchResult();

        void EnableDumpControl(bool enable);

        void EnableDumpButton(bool enable);

        void SetContextMenuItemText(string[] menuItemsText);

        void LazyInitializeContextMenu();

        void EnableContextMenuItems(bool enable);

        void ShowGroups(bool show);

        bool ZipFiles { get; set; }
    }
}