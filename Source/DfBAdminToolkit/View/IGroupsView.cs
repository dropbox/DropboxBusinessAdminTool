namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Model;
    using System;
    using System.Collections.Generic;

    public interface IGroupsView
        : IView
    {
        event EventHandler CommandGetGroups;
        event EventHandler CommandCreateGroup;
        event EventHandler CommandExportGroups;
        event EventHandler CommandExportGroupPerms;
        event EventHandler CommandAddMember;
        event EventHandler CommandDeleteMember;
        event EventHandler CommandLoadGroupsInputFile;
        event EventHandler CommandLoadGroupsMembersInputFile;

        string AccessToken { get; set; }

        void RefreshAccessToken();

        string GroupName { get; set; }

        string GroupType { get; set; }

        string UserEmail { get; set; }

        string AddStatus { get; set; }

        string GroupInputFilePath { get; set; }

        string GroupMemberInputFilePath { get; set; }

        void RenderGroupList(List<GroupListViewItemModel> groups);

        void RenderGroupsStatus(List<GroupListViewItemModel> groups);

        bool MultiGroupCreateCheck();

        bool MultiGroupMemberCreateCheck();
    }
}