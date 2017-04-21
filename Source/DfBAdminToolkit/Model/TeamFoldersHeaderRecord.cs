using CsvHelper.Configuration;

namespace DfBAdminToolkit.Model
{

    public class TeamFoldersHeaderRecord
    {
        public string TeamFolderName { get; set; }
        public string TeamFolderId { get; set; }
        public string TeamFolderStatus { get; set; }
    }

    public class TeamFoldersHeaderMap : CsvClassMap<TeamFoldersHeaderRecord>
    {
        public TeamFoldersHeaderMap()
        {
            Map(m => m.TeamFolderName).Name("TeamFolderName");
            Map(m => m.TeamFolderId).Name("TeamFolderId");
            Map(m => m.TeamFolderStatus).Name("Status");
        }
    }
}
