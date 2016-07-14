using System.Collections.Generic;

namespace MTSQL.Core.Models.Metadata
{
    public class MetadataTableModel
    {
        public List<MetadataColumnModel> Columns { get; private set; } = new List<MetadataColumnModel>();

        public string Name { get; set; }
    }
}
