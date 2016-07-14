using MTSQL.Core.Enums.Oracle.Sequence;

namespace MTSQL.Core.Models.Database.Oracle.Sequence
{
    public class OracleSequenceModel
    {
        public string Name                    { get; set; } = string.Empty;
        public object StartsWith              { get; set; } = "1";
        public object IncrementBy             { get; set; } = "1";
        public OracleSequenceMinValueModel MinValue { get; set; } = new OracleSequenceMinValueModel(OracleSequenceMinValue.MINVALUE, "1"                           );
        public OracleSequenceMaxValueModel MaxValue { get; set; } = new OracleSequenceMaxValueModel(OracleSequenceMaxValue.MAXVALUE, "9999999999999999999999999999");
        public OracleSequenceCacheModel    Cache    { get; set; } = new OracleSequenceCacheModel   (OracleSequenceCache.NOCACHE    , null                          );
        public OracleSequenceOrderModel    Order    { get; set; } = new OracleSequenceOrderModel   (OracleSequenceOrder.ORDER      , null                          );
        public OracleSequenceCycleModel    Cycle    { get; set; } = new OracleSequenceCycleModel   (OracleSequenceCycle.NOCYCLE    , null                          );

        public OracleSequenceModel(string name)
        {
            Name = name;
        }
    }                             
}