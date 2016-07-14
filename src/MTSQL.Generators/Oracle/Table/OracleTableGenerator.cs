using System.Text;
using System.Linq;
using MTSQL.Core.Models.Database.Oracle.Table;
using MTSQL.Core.Models.Database.Oracle.Column;
using MTSQL.Generators.Generators.Oracle.Column;
using System;
using MTSQL.Core.Enums;

namespace MTSQL.Generators.Generators.Oracle.Table
{
    public class OracleTableGenerator : IDBObjectScriptGenerator<OracleTableModel>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateHeader(OracleTableModel obj)
        {
            var sb = new StringBuilder();

            sb.AppendLine("--");
            sb.AppendLine("-- Creating table " + obj.Name);
            sb.AppendLine("-- ===============" + string.Empty.PadRight(obj.Name.Length, '='));
            sb.AppendLine("--");

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateFooter(OracleTableModel obj)
        {
            return ";";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateObject(OracleTableModel obj)
        {
            var sb = new StringBuilder();

            sb.Append("CREATE TABLE " + obj.Name + " (");

            var c_generator = new OracleColumnGenerator();
 
            foreach(var column in obj.Columns)
            {
                if (column.DbType.ToLower() == "mlstring")
                {
                    var mlColumn_tr = new OracleColumnModel
                    {
                        DbType     = "nvarchar",
                        Name       = column.Name + MLKeys._TR_TR,
                        IsPrimary  = column.IsPrimary,
                        Size       = column.Size,
                        IsNullable = column.IsNullable,
                        Precision  = column.Precision,
                        Scale      = column.Scale
                    };

                    var mlColumn_en = new OracleColumnModel
                    {
                        DbType     = "nvarchar",
                        Name       = column.Name + MLKeys._EN_GB,
                        IsPrimary  = column.IsPrimary,
                        Size       = column.Size,
                        IsNullable = column.IsNullable,
                        Precision  = column.Precision,
                        Scale      = column.Scale
                    };

                    sb.Append(c_generator.GenerateScript(mlColumn_tr));
                    sb.Append(","                              );
                    sb.Append(c_generator.GenerateScript(mlColumn_en));
                }
                else
                {
                    sb.Append(c_generator.GenerateScript(column));
                }

                if(column.Name != obj.Columns.Last().Name)
                {
                    sb.Append(",");
                }
            }

            sb.Append(")");

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateScript(OracleTableModel obj)
        {
            var sb = new StringBuilder();

            sb.AppendLine(GenerateHeader(obj));
            sb.Append    (GenerateObject(obj));
            sb.AppendLine(GenerateFooter(obj));

            return sb.ToString();
        }
    }
}
