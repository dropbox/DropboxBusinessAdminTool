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
        event EventHandler CommandAddMember;
        event EventHandler CommandDeleteMember;

        string AccessToken { get; set; }

        void RefreshAccessToken();

        string GroupName { get; set; }

        string UserEmail { get; set; }

        void RenderGroupList();
    }
}