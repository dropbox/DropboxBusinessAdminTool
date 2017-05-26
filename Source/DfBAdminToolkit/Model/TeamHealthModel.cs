namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public class TeamHealthModel
       : ITeamHealthModel {

        public string AccessToken { get; set; }

        public TeamHealthModel() {
            Initialize();
        }

        public void Initialize() {
            AccessToken = ApplicationResource.DefaultProvisionToken;
        }

        public void CleanUp() {
        }
    }
}