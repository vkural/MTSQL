using MTSQL.Core.Models.Database.Oracle.Column;
using System.Collections.Generic;
using System.Linq;

namespace MTSQL.Core.Models.Database.Oracle.Table
{
    public class OracleTableModel
    {
        public IEnumerable<OracleColumnModel> Columns { get; set; } = Enumerable.Empty<OracleColumnModel>();

        public string Name { get; set; }
    }
}
