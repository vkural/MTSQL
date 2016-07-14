using MTSQL.Core.Enums;
using MTSQL.Generators.Generators;
using MTSQL.Generators.Mssql;

namespace MTSQL.Generators
{
    public abstract class ScriptGeneratorFactory
    {
        public static IDBScriptGenerator CreateGenerator(DBTypes type)
        {
            switch (type)
            {
                case DBTypes.MSSQL:
                    return new MssqlScriptGenerator();
                case DBTypes.ORACLE:
                    return new OracleScriptGenerator();
                default:
                    return null;
            }
        }
    }
}