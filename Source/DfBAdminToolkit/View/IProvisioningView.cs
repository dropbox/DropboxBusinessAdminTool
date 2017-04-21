namespace DfBAdminToolkit.View
{
    using DfBAdminToolkit.Model;
    using System;
    using System.Collections.Generic;

    public interface IProvisioningView
        : IView
    {
        event EventHandler CommandProvision;
        event EventHandler CommandDeprovision;
        event EventHandler CommandSuspend;
        event EventHandler CommandUnsuspend;
        event EventHandler CommandUpdateProfile;
        event EventHandler CommandLoadInputFile;
        event EventHandler CommandLoadUpdateInputFile;
        event EventHandler CommandCreateCSV;
        event EventHandler CommandGetUsage;
        event EventHandler CommandRecover;

        bool SendWelcomeEmail { get; set; }

        string AccessToken { get; set; }

        string InputFilePath { get; set; }

        string SelectedRole { get; set; }

        bool KeepAccount { get; set; }

        bool RemoveSharing { get; set; }

        void EnableProvisionButton(bool enable);

        void EnableDeprovisionButton(bool enable);

        void EnableSuspendButton(bool enable);

        void EnableUnSuspendButton(bool enable);

        void EnableLoadInputFileButton(bool enable);

        void EnableUpdateProfileButton(bool enable);

        void EnableRecoverButton(bool enable);

        void RefreshAccessToken();

        void RenderMemberList(List<MemberListViewItemModel> members);

        void RenderUpdateMemberList(List<MemberListViewItemModel> members);

        void RenderProvisioningStatus(List<MemberListViewItemModel> members);
    }
}