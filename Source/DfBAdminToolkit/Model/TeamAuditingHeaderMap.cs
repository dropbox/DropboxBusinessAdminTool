using CsvHelper.Configuration;

namespace DfBAdminToolkit.Model
{
    public class TeamAuditingHeaderRecord
    {
        public string Timestamp { get; set; }
        public string ActorType { get; set; }
        public string Email { get; set; }
        public string Context { get; set; }
        public string EventType { get; set; }
        public string Origin { get; set; }
        public string IpAddress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Participants { get; set; }
        public string Assets { get; set; }
    }

    public class TeamAuditingHeaderMap : CsvClassMap<TeamAuditingHeaderRecord>
    {
        public TeamAuditingHeaderMap()
        {
            Map(m => m.Timestamp).Name("Timestamp");
            Map(m => m.ActorType).Name("ActorType");
            Map(m => m.Email).Name("Actor");
            Map(m => m.Context).Name("Context");
            Map(m => m.EventType).Name("EventType");
            Map(m => m.Origin).Name("Origin");
            Map(m => m.IpAddress).Name("IpAddress");
            Map(m => m.City).Name("City");
            Map(m => m.Region).Name("Region");
            Map(m => m.Country).Name("Country");
            Map(m => m.Participants).Name("Participants");
            Map(m => m.Assets).Name("Assets");
        }
    }
}