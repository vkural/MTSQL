using MTSQL.Core.Enums.Oracle.Sequence;

namespace MTSQL.Core.Models.Database.Oracle.Sequence
{
    public class OracleSequenceCycleModel
    {
        public OracleSequenceCycle Key   { get; private set; }
        public object        Value { get; private set; }

        public OracleSequenceCycleModel(OracleSequenceCycle key, object value)
        {
            Key   = key;
            Value = value;
        }
    }
}
