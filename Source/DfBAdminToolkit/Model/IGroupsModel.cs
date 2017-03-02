namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public interface IGroupsModel
        : IModel {

        string AccessToken { get; set; }

        string GroupInputFilePath { get; set; }

        string GroupMemberInputFilePath { get; set; }

        List<GroupListViewItemModel> Groups { get; set; }

        List<GroupInfoItemModel> GroupInfo { get; set; }

        List<GroupPermsItemModel> GroupPerms { get; set; }
    }
}