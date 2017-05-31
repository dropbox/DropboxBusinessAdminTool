namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public interface ITeamAuditingModel
        : IModel {

        string AccessToken { get; set; }

        string MemberInputFilePath { get; set; }

        List<TeamAuditingListViewItemModel> TeamAuditing { get; set; }
    }
}