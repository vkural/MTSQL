using MTSQL.Core.Enums.Oracle.Sequence;

namespace MTSQL.Core.Models.Database.Oracle.Sequence
{
    public class OracleSequenceOrderModel
    {
        public OracleSequenceOrder Key   { get; private set; }
        public object        Value { get; private set; }

        public OracleSequenceOrderModel(OracleSequenceOrder key, object value)
        {
            Key   = key;
            Value = value;
        }
    }
}