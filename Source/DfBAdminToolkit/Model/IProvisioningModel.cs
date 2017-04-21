namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;
    using System;

    public interface IProvisioningModel
        : IModel {
        bool SendWelcomeEmail { get; set; }

        string AccessToken { get; set; }

        string InputFilePath { get; set; }

        string SelectedRole { get; set; }

        bool KeepAccount { get; set; }

        bool RemoveSharing { get; set; }

        string NewEmail { get; set; }

        string NewExternalId { get; set; }

        string ProvisionStatus { get; set; }

        DateTime JoinedOn { get; set; }

        List<MemberListViewItemModel> Members { get; set; }
    }
}