namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public class TeamAuditingModel
       : ITeamAuditingModel {

        public string AccessToken { get; set; }

        public string MemberInputFilePath { get; set; }

        public List<TeamAuditingListViewItemModel> TeamAuditing { get; set; }

        public TeamAuditingModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            TeamAuditing = new List<TeamAuditingListViewItemModel>();
            AccessToken = ApplicationResource.DefaultProvisionToken;
        }

        public void CleanUp()
        {
        }
    }
}