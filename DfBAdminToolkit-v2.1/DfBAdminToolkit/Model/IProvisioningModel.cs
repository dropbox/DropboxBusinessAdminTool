namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public interface IProvisioningModel
        : IModel {
        bool SendWelcomeEmail { get; set; }

        string AccessToken { get; set; }

        string InputFilePath { get; set; }

        string SelectedRole { get; set; }

        List<MemberListViewItemModel> Members { get; set; }
    }
}