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
        event EventHandler CommandLoadInputFile;
        event EventHandler CommandCreateCSV;

        bool SendWelcomeEmail { get; set; }

        string AccessToken { get; set; }

        string InputFilePath { get; set; }

        string SelectedRole { get; set; }

        void EnableProvisionButton(bool enable);

        void EnableDeprovisionButton(bool enable);

        void EnableLoadInputFileButton(bool enable);

        void RefreshAccessToken();

        void RenderMemberList(List<MemberListViewItemModel> members);
    }
}