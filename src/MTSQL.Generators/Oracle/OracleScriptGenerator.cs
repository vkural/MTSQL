using System.Collections.Generic;
using System.Text;
using System.Linq;
using MTSQL.Core.Models.Database.Oracle.Sequence;
using MTSQL.Generators.Generators.Oracle.Table;
using MTSQL.Generators.Generators.Oracle.Sequence;
using MTSQL.Core.Models.Database.Oracle.Table;
using MTSQL.Core.Models.Database.Oracle.Column;
using MTSQL.Core.Extensions;
using System.IO;

namespace MTSQL.Generators.Generators
{
    public class OracleScriptGenerator : DBScriptGenerator
    {
        public override string GenerateScript(List<string> fileNames)
        {
            base.Load(fileNames);

            string query = this.GetQuery();

            return query;
        }

        public override string GenerateScript(List<MemoryStream> streams)
        {
            base.Load(streams);

            string query = this.GetQuery();

            return query;
        }

        public string GetQuery()
        {
            var sb         = new StringBuilder          ();
            var tGenerator = new OracleTableGenerator   ();
            var sGenerator = new OracleSequenceGenerator();

            var sequences  = Tables.SelectMany(x => x.Columns.Where(y => !string.IsNullOrEmpty(y.SequenceName)).Select(z => new OracleSequenceModel(z.SequenceName)));

            foreach (var sequence in sequences)
            {
                var txt = sGenerator.GenerateScript(sequence);

                sb.AppendLine(txt);
            }

            foreach (var table in Tables)
            {
                var txt = tGenerator.GenerateScript(new OracleTableModel
                {
                    Name    = table.Name,
                    Columns = table.Columns.Select(x => new OracleColumnModel
                    {
                        DbType     = x.DbType,
                        Name       = x.Name,
                        IsNullable = string.IsNullOrEmpty(x.IsNullable) ? false : x.IsNullable == "0"    ? false                  : x.IsNullable == "1" ? true : false,
                        IsPrimary  = string.IsNullOrEmpty(x.IsPrimary ) ? false : x.IsPrimary  == "0"    ? false                  : x.IsPrimary  == "1" ? true : false,
                        Precision  = string.IsNullOrEmpty(x.Precision ) ? 0     : x.Precision.IsNumber() ? int.Parse(x.Precision) : 0,
                        Scale      = string.IsNullOrEmpty(x.Scale     ) ? 0     : x.Scale    .IsNumber() ? int.Parse(x.Scale    ) : 0,
                        Size       = string.IsNullOrEmpty(x.Size      ) ? 0     : x.Size     .IsNumber() ? int.Parse(x.Size     ) : 0,
                    })
                });

                sb.AppendLine(txt);
            }

            return sb.ToString();
        }
    }
}
