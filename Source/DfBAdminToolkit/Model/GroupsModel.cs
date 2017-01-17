namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public class GroupsModel
       : IGroupsModel {

        public string AccessToken { get; set; }

        public List<GroupListViewItemModel> Groups { get; set; }

        public List<GroupInfoItemModel> GroupInfo { get; set; }

        public GroupsModel() {
            Initialize();
        }

        public void Initialize() {
            Groups = new List<GroupListViewItemModel>();
            GroupInfo = new List<GroupInfoItemModel>();
            AccessToken = ApplicationResource.DefaultProvisionToken;
        }

        public void CleanUp() {
        }
    }
}