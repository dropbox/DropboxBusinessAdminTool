namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public interface IDumpUserContentModel
        : IModel {
        string UserAccessToken { get; set; }

        List<TeamListViewItemModel> MemberList { get; set; }

        string OutputFolder { get; set; }

        bool ZipFiles { get; set; }

        bool SuspendUser { get; set; }

        bool DeleteUser { get; set; }

        bool KeepAccount { get; set; }

        bool RemoveSharing { get; set; }
    }
}