namespace MTSQL.Core.Models.Metadata
{
    public class MetadataColumnModel
    {
        public string Name         { get; set; }
        public string DbType       { get; set; }
        public string Size         { get; set; }
        public string IsIdentity   { get; set; }
        public string IsNullable   { get; set; }
        public string IsPrimary    { get; set; }
        public string Scale        { get; set; }
        public string Precision    { get; set; }
        public string SequenceName { get; set; }
    }
}