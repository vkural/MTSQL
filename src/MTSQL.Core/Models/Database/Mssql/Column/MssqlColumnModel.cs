namespace MTSQL.Core.Models.Database.Oracle.Column
{
    public class MssqlColumnModel
    {
        public string Name       { get; set; }
        public string DbType     { get; set; }
        public int    Size       { get; set; }
        public bool   IsNullable { get; set; }
        public bool   IsPrimary  { get; set; }
        public bool   IsIdentity { get; set; }
        public int    Scale      { get; set; }
        public int    Precision  { get; set; }
    }
}
