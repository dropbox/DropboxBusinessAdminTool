namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public class TeamAuditingModel
       : ITeamAuditingModel {

        public string AccessToken { get; set; }

        public TeamAuditingModel() {
            Initialize();
        }

        public void Initialize() {
            AccessToken = ApplicationResource.DefaultProvisionToken;
        }

        public void CleanUp() {
        }
    }
}