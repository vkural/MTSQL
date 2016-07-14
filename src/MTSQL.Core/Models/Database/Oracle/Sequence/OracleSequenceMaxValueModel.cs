using MTSQL.Core.Enums.Oracle.Sequence;

namespace MTSQL.Core.Models.Database.Oracle.Sequence
{
    public class OracleSequenceMaxValueModel
    {
        public OracleSequenceMaxValue Key   { get; private set; }
        public object           Value { get; private set; }

        public OracleSequenceMaxValueModel(OracleSequenceMaxValue key, object value)
        {
            Key   = key;
            Value = value;
        }
    }
}