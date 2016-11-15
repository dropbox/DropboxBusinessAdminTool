namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public class ProvisioningModel
       : IProvisioningModel {
        public bool SendWelcomeEmail { get; set; }

        public string AccessToken { get; set; }

        public string InputFilePath { get; set; }

        public string SelectedRole { get; set; }

        public bool KeepAccount { get; set; }

        public string NewEmail { get; set; }

        public string NewExternalId { get; set; }

        public string ProvisionStatus { get; set; }

        public List<MemberListViewItemModel> Members { get; set; }

        public ProvisioningModel() {
            Initialize();
        }

        public void Initialize() {
            Members = new List<MemberListViewItemModel>();
            AccessToken = ApplicationResource.DefaultProvisionToken;
            SelectedRole = string.Empty;
            SendWelcomeEmail = true;
            ProvisionStatus = string.Empty;
            KeepAccount = false;
        }

        public void CleanUp() {
        }
    }
}