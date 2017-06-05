using CsvHelper.Configuration;

namespace DfBAdminToolkit.Model
{

    public class PaperHeaderRecord
    {
        public string PaperName { get; set; }
        public string PaperId { get; set; }
        public string FolderPath { get; set; }
        public string Status { get; set; }
        public string Owner { get; set; }
        public string CreatedDate { get; set; }
        public string LastUpdatedDate { get; set; }
        public string LastEditor { get; set; }
        public string Revision { get; set; }
    }

    public class PaperHeaderMap : CsvClassMap<PaperHeaderRecord>
    {
        public PaperHeaderMap()
        {
            Map(m => m.PaperName).Name("PaperName");
            Map(m => m.PaperId).Name("PaperId");
            Map(m => m.FolderPath).Name("FolderPath");
            Map(m => m.Status).Name("Status");
            Map(m => m.Owner).Name("Owner");
            Map(m => m.CreatedDate).Name("CreatedDate");
            Map(m => m.LastUpdatedDate).Name("LastUpdatedDate");
            Map(m => m.LastEditor).Name("LastEditor");
            Map(m => m.Revision).Name("Revision");
        }
    }
}