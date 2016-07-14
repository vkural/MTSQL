using MTSQL.Core.Models.Database.Oracle.Column;
using System.Collections.Generic;
using System.Linq;

namespace MTSQL.Core.Models.Database.Oracle.Table
{
    public class MssqlTableModel
    {
        public IEnumerable<MssqlColumnModel> Columns { get; set; } = Enumerable.Empty<MssqlColumnModel>();

        public string Name { get; set; }
    }
}
