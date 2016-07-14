using System.Text;
using System.Linq;
using MTSQL.Core.Models.Database.Oracle.Table;
using MTSQL.Core.Models.Database.Oracle.Column;
using MTSQL.Generators.Generators.Oracle.Column;
using System;
using MTSQL.Core.Enums;

namespace MTSQL.Generators.Generators.Oracle.Table
{
    public class MssqlTableGenerator : IDBObjectScriptGenerator<MssqlTableModel>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateHeader(MssqlTableModel obj)
        {
            var sb = new StringBuilder();

            sb.AppendLine("GO");
            sb.AppendLine("/****** Object: Table [dbo].[" + obj.Name + "]    Script Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " ******/ ");
            sb.AppendLine("SET ANSI_NULLS ON");
            sb.AppendLine("GO");
            sb.AppendLine("SET QUOTED_IDENTIFIER ON");
            sb.AppendLine("GO");

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateFooter(MssqlTableModel obj)
        {
            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateObject(MssqlTableModel obj)
        {
            var sb = new StringBuilder();

            sb.Append("CREATE TABLE " + obj.Name + " (");

            var c_generator = new MssqlColumnGenerator();
 
            foreach(var column in obj.Columns)
            {
                if (column.DbType.ToLower() == "mlstring")
                {
                    var mlColumn_tr = new MssqlColumnModel
                    {
                        DbType     = "nvarchar",
                        Name       = column.Name + MLKeys._TR_TR,
                        IsIdentity = column.IsIdentity,
                        IsPrimary  = column.IsPrimary,
                        Size       = column.Size,
                        IsNullable = column.IsNullable,
                        Precision  = column.Precision,
                        Scale      = column.Scale
                    };

                    var mlColumn_en = new MssqlColumnModel
                    {
                        DbType     = "nvarchar",
                        Name       = column.Name + MLKeys._EN_GB,
                        IsIdentity = column.IsIdentity,
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
        public string GenerateScript(MssqlTableModel obj)
        {
            var sb = new StringBuilder();

            sb.AppendLine(GenerateHeader(obj));
            sb.Append    (GenerateObject(obj));
            sb.AppendLine(GenerateFooter(obj));

            return sb.ToString();
        }
    }
}
