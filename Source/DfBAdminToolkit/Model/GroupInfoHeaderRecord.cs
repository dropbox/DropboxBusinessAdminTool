using CsvHelper.Configuration;

namespace DfBAdminToolkit.Model
{

    public class GroupInfoHeaderRecord
    {
        public string GroupName { get; set; }
        public string GroupId { get; set; }
        public string GroupType { get; set; }
        public string TeamMemberId { get; set; }
        public string Email { get; set; }
        public string EmailVerified { get; set; }
        public string Status { get; set; }
        public string MembershipType { get; set; }
        public string JoinedOn { get; set; }
        public string AccessType { get; set; }
    }

    public class GroupInfoHeaderMap : CsvClassMap<GroupInfoHeaderRecord>
    {
        public GroupInfoHeaderMap()
        {
            Map(m => m.GroupName).Name("GroupName");
            Map(m => m.GroupId).Name("GroupId");
            Map(m => m.GroupType).Name("GroupManagementType");
            Map(m => m.TeamMemberId).Name("TeamMemberId");
            Map(m => m.Email).Name("Email");
            Map(m => m.EmailVerified).Name("EmailVerified");
            Map(m => m.Status).Name("Status");
            Map(m => m.MembershipType).Name("MembershipType");
            Map(m => m.JoinedOn).Name("JoinedOn");
            Map(m => m.AccessType).Name("AccessType");
        }
    }
}

