using MTSQL.Core;
using MTSQL.Core.Enums.Oracle;
using MTSQL.Core.Enums.Oracle.Column;
using MTSQL.Core.Models.Database.Oracle.Column;
using System.Text;

namespace MTSQL.Generators.Generators.Oracle.Column
{
    public class OracleColumnGenerator : IDBObjectScriptGenerator<OracleColumnModel>
    {
        public string GenerateHeader(OracleColumnModel obj)
        {
            return string.Empty;
        }

        public string GenerateObject(OracleColumnModel obj)
        {
            switch (obj.DbType.ToLowerInvariant())
            {
                case "varchar"       :
                    obj.DbType = string.Format("{0}({1})", OracleColumnTypes.VARCHAR2 , obj.Size < 0 ? 2000 : obj.Size);
                    break;

                case "nvarchar"      :
                case "ntext"         :
                    obj.DbType = string.Format("{0}({1})", OracleColumnTypes.NVARCHAR2, obj.Size < 0 ? 2000 : obj.Size);
                    break;

                case "char"          :
                    obj.DbType = string.Format("{0}({1})", OracleColumnTypes.CHAR     , obj.Size < 0 ? 2000 : obj.Size);
                    break;

                case "integer"       :
                case "int"           :
                    obj.DbType = OracleColumnTypes.NUMBER10;
                    break;

                case "image"         :
                    obj.DbType = OracleColumnTypes.BLOB;
                    break;

                case "datetime"      :
                case "date"          :
                case "smalldatetime" :
                    obj.DbType = OracleColumnTypes.DATE;
                    break;

                case "boolean"       :
                case "bool"          :
                    obj.DbType = OracleColumnTypes.NUMBER3;
                    break;

                case "float"         :
                    obj.DbType = OracleColumnTypes.FLOAT49;
                    break;

                case "xml"           :
                    obj.DbType = OracleColumnTypes.CLOB;
                    break;

                case "guid"          :
                    obj.DbType = OracleColumnTypes.CHAR36;
                    break;

                case "decimal"       :
                    obj.DbType = string.Format("{0}({1},{2})", OracleColumnTypes.NUMBER, obj.Precision, obj.Scale);
                    break;

                default:
                    obj.DbType = string.Empty;
                    break;
            }

            var txt = string.Format("\"{0}\" {1} {2} {3}",
                obj.Name,
                obj.DbType, 
                obj.IsNullable ? (obj.IsPrimary ? OracleReservedKeywords.NOTNULL : OracleReservedKeywords.NULL ) : OracleReservedKeywords.NOTNULL,
                obj.IsPrimary  ? (OracleReservedKeywords.PRIMARYKEY                                            ) : OracleReservedKeywords.EMPTY  );

            return txt.Trim();
        }

        public string GenerateFooter(OracleColumnModel obj)
        {
            return string.Empty;
        }

        public string GenerateScript(OracleColumnModel obj)
        {
            var sb = new StringBuilder();

            sb.AppendLine(GenerateHeader(obj));
            sb.Append    (GenerateObject(obj));
            sb.Append    (GenerateFooter(obj));

            return sb.ToString();
        }
    }
}
