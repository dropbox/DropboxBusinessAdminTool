using CsvHelper.Configuration;

namespace DfBAdminToolkit.Model
{
    public class TeamFoldersMembersHeaderRecord
    {
        public string TeamFolderName { get; set; }
        public string TeamFolderPath { get; set; }
        public string TeamFolderMember { get; set; }
        public string TeamFolderMemberId { get; set; }
        public string TeamFolderAccessType { get; set; }
        public string MemberCount { get; set; }
    }

    public class TeamFoldersMembersHeaderMap : CsvClassMap<TeamFoldersMembersHeaderRecord>
    {
        public TeamFoldersMembersHeaderMap()
        {
            Map(m => m.TeamFolderName).Name("TeamFolderName");
            Map(m => m.TeamFolderPath).Name("Path");
            Map(m => m.TeamFolderMember).Name("Member");
            Map(m => m.TeamFolderMemberId).Name("Id");
            Map(m => m.TeamFolderAccessType).Name("AccessType");
            Map(m => m.MemberCount).Name("MemberCount");
        }
    }
}
