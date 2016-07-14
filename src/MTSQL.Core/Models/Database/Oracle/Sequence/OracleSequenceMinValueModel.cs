using MTSQL.Core.Enums.Oracle.Sequence;

namespace MTSQL.Core.Models.Database.Oracle.Sequence
{
    public class OracleSequenceMinValueModel
    {
        public OracleSequenceMinValue Key   { get; private set; }
        public object           Value { get; private set; }

        public OracleSequenceMinValueModel(OracleSequenceMinValue key, object value)
        {
            Key   = key;
            Value = value;
        }
    }
}