namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public interface IProvisioningModel
        : IModel {
        bool SendWelcomeEmail { get; set; }

        string AccessToken { get; set; }

        string InputFilePath { get; set; }

        string SelectedRole { get; set; }

        bool KeepAccount { get; set; }

        string NewEmail { get; set; }

        string NewExternalId { get; set; }

        string ProvisionStatus { get; set; }

        string JoinedOn { get; set; }

        List<MemberListViewItemModel> Members { get; set; }
    }
}