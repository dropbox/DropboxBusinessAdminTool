using CsvHelper.Configuration;

namespace DfBAdminToolkit.Model
{

    public class GroupPermsHeaderRecord
    {
        public string GroupName { get; set; }
        public string GroupId { get; set; }
        public string GroupManagementType { get; set; }
        public string GroupType { get; set; }
        public string SharedFolderName { get; set; }
        public string SharedFolderId { get; set; }
        public string AccessType { get; set; }
        public string IsMember { get; set; }
        public string IsOwner { get; set; }
        public string IsInherited { get; set; }
        public string IsTeamFolder { get; set; }
        public string IsInsideTeamFolder { get; set; }
    }

    public class GroupPermsHeaderMap : CsvClassMap<GroupPermsHeaderRecord>
    {
        public GroupPermsHeaderMap()
        {      
            Map(m => m.GroupName).Name("GroupName");
            Map(m => m.GroupId).Name("GroupId");
            Map(m => m.GroupManagementType).Name("GroupManagementType");
            Map(m => m.GroupType).Name("GroupType");
            Map(m => m.SharedFolderName).Name("SharedFolderName");
            Map(m => m.SharedFolderId).Name("SharedFolderId");
            Map(m => m.IsMember).Name("IsMember");
            Map(m => m.IsOwner).Name("IsOwner");
            Map(m => m.AccessType).Name("AccessType");
            Map(m => m.IsInherited).Name("IsInherited");
            Map(m => m.IsTeamFolder).Name("IsTeamFolder");
            Map(m => m.IsInsideTeamFolder).Name("IsInsideTeamFolder");
        }
    }
}
