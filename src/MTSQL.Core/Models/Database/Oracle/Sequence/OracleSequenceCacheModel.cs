using MTSQL.Core.Enums.Oracle.Sequence;

namespace MTSQL.Core.Models.Database.Oracle.Sequence
{
    public class OracleSequenceCacheModel
    {
        public OracleSequenceCache Key   { get; private set; }
        public object        Value { get; private set; }

        public OracleSequenceCacheModel(OracleSequenceCache key, object value)
        {
            Key   = key;
            Value = value;
        }
    }
}