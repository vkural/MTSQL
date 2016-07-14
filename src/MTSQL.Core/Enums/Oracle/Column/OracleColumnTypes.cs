namespace MTSQL.Core.Enums.Oracle.Column
{
    public struct OracleColumnTypes
    {
        ///  http://docs.oracle.com/cd/B19306_01/gateways.102/b14270/apa.htm

        public const string CHAR36    = "CHAR(36)"  ; // MSSQL => UNIQUEIDENTIFIER
        public const string FLOAT49   = "FLOAT(49)" ; // MSSQL => FLOAT
        public const string DATE      = "DATE"      ; // MSSQL => DATETIME
        public const string NUMBER10  = "NUMBER(10)"; // MSSQL => INT
        public const string NUMBER3   = "NUMBER(3)" ; // MSSQL => BIT
        public const string VARCHAR2  = "VARCHAR2"  ; // MSSQL => VARCHAR
        public const string CHAR      = "CHAR"      ; // MSSQL => CHAR
        public const string NVARCHAR2 = "NVARCHAR2" ; // MSSQL => NVARCHAR
        public const string NUMBER    = "NUMBER"    ; // MSSQL => DECIMAL4
        public const string CLOB      = "CLOB"      ; // MSSQL => XML
        public const string BLOB      = "BLOB"      ; // MSSQL => IMAGE
    }
}