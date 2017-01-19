namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;

    public class GroupsModel
       : IGroupsModel {

        public string AccessToken { get; set; }

        public List<GroupListViewItemModel> Groups { get; set; }

        public List<GroupInfoItemModel> GroupInfo { get; set; }

        public List<GroupPermsItemModel> GroupPerms { get; set; }

        public GroupsModel() {
            Initialize();
        }

        public void Initialize() {
            Groups = new List<GroupListViewItemModel>();
            GroupInfo = new List<GroupInfoItemModel>();
            GroupPerms = new List<GroupPermsItemModel>();
            AccessToken = ApplicationResource.DefaultAccessToken;
        }

        public void CleanUp() {
        }
    }
}