namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public interface IGroupsModel
        : IModel {

        string AccessToken { get; set; }

        List<GroupListViewItemModel> Groups { get; set; }

        List<GroupInfoItemModel> GroupInfo { get; set; }
    }
}