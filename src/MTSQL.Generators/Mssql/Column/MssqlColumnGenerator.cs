using MTSQL.Core;
using MTSQL.Core.Enums.Mssql.Column;
using MTSQL.Core.Enums.Oracle;
using MTSQL.Core.Models.Database.Oracle.Column;
using System;
using System.Text;

namespace MTSQL.Generators.Generators.Oracle.Column
{
    public class MssqlColumnGenerator : IDBObjectScriptGenerator<MssqlColumnModel>
    {
        public string GenerateHeader(MssqlColumnModel obj)
        {
            return string.Empty;
        }

        public string GenerateObject(MssqlColumnModel obj)
        {
            switch (obj.DbType.ToLowerInvariant())
            {
                case "varchar"       :
                    obj.DbType = string.Format("{0}({1})", MssqlColumnTypes.VARCHAR , obj.Size  < 0 ? MssqlReservedKeywords.MAX : obj.Size.ToString());
                    break;

                case "nvarchar"      :
                case "ntext"         :
                    obj.DbType = string.Format("{0}({1})", MssqlColumnTypes.NVARCHAR, obj.Size  < 0 ? MssqlReservedKeywords.MAX : obj.Size.ToString());
                    break;

                case "char"          :
                    obj.DbType = string.Format("{0}({1})", MssqlColumnTypes.CHAR     , obj.Size < 0 ? MssqlReservedKeywords.MAX : obj.Size.ToString());
                    break;

                case "integer"       :
                case "int"           :
                    obj.DbType = MssqlColumnTypes.INT;
                    break;

                case "image"         :
                    obj.DbType = MssqlColumnTypes.IMAGE;
                    break;

                case "datetime"      :
                    obj.DbType = MssqlColumnTypes.DATETIME;
                    break;

                case "date"          :
                    obj.DbType = MssqlColumnTypes.DATE;

                    break;
                case "smalldatetime" :
                    obj.DbType = MssqlColumnTypes.SMALLDATETIME;
                    break;

                case "boolean"       :
                case "bool"          :
                    obj.DbType = MssqlColumnTypes.BIT;
                    break;

                case "float"         :
                    obj.DbType = MssqlColumnTypes.FLOAT;
                    break;

                case "xml"           :
                    obj.DbType = MssqlColumnTypes.XML;
                    break;

                case "guid"          :
                    obj.DbType = MssqlColumnTypes.UNIQUEIDENTIFIER;
                    break;

                case "decimal"       :
                    obj.DbType = string.Format("{0}({1},{2})", MssqlColumnTypes.DECIMAL, obj.Precision, obj.Scale);
                    break;

                default:
                    obj.DbType = string.Empty;
                    break;
            }

            var txt = string.Format("[{0}] {1} {2} {3}",
                obj.Name,
                obj.DbType, 
                obj.IsNullable ? (obj.IsPrimary ? MssqlReservedKeywords.NOTNULL : MssqlReservedKeywords.NULL ) : MssqlReservedKeywords.NOTNULL,
                obj.IsPrimary  ? (MssqlReservedKeywords.PRIMARYKEY                                           ) : MssqlReservedKeywords.EMPTY  ,
                obj.IsIdentity ? (MssqlReservedKeywords.IDENTITY                                             ) : MssqlReservedKeywords.EMPTY  );

            return txt.Trim();
        }

        public string GenerateFooter(MssqlColumnModel obj)
        {
            return string.Empty;
        }

        public string GenerateScript(MssqlColumnModel obj)
        {
            var sb = new StringBuilder();

            sb.AppendLine(GenerateHeader(obj));
            sb.Append    (GenerateObject(obj));
            sb.Append    (GenerateFooter(obj));

            return sb.ToString();
        }
    }
}
