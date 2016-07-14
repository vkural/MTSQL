using System.Text;
using MTSQL.Core.Models.Database.Oracle.Sequence;
using MTSQL.Core.Enums.Oracle.Sequence;

namespace MTSQL.Generators.Generators.Oracle.Sequence
{
    public class OracleSequenceGenerator : IDBObjectScriptGenerator<OracleSequenceModel>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateHeader(OracleSequenceModel obj)
        {
            var sb = new StringBuilder();

            sb.AppendLine("--");
            sb.AppendLine("-- Creating sequence " + obj.Name);
            sb.AppendLine("-- ==================" + string.Empty.PadRight(obj.Name.Length, '='));
            sb.AppendLine("--");

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateFooter(OracleSequenceModel obj)
        {
            return ";";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateObject(OracleSequenceModel obj)
        {
            var sb = new StringBuilder();

            sb.AppendLine("CREATE SEQUENCE " + obj.Name);

            switch (obj.MinValue.Key)
            {
                case OracleSequenceMinValue.MINVALUE:
                    sb.AppendLine("MINVALUE " + obj.MinValue.Value);
                    break;
                case OracleSequenceMinValue.NOMINVALUE:
                    sb.AppendLine("NOMINVALUE");
                    break;
            }

            switch (obj.MaxValue.Key)
            {
                case OracleSequenceMaxValue.MAXVALUE:
                    sb.AppendLine("MAXVALUE " + obj.MaxValue.Value);
                    break;
                case OracleSequenceMaxValue.NOMAXVALUE:
                    sb.AppendLine("NOMAXVALUE");
                    break;
            }

            sb.AppendLine("START WITH "   + obj.StartsWith );
            sb.AppendLine("INCREMENT BY " + obj.IncrementBy);

            switch (obj.Cache.Key)
            {
                case OracleSequenceCache.CACHE:
                    sb.AppendLine("CACHE " + obj.Cache.Value);
                    break;
                case OracleSequenceCache.NOCACHE:
                    sb.AppendLine("NOCACHE");
                    break;
            }

            switch (obj.Order.Key)
            {
                case OracleSequenceOrder.ORDER:
                    sb.AppendLine("ORDER");
                    break;
                case OracleSequenceOrder.NOORDER:
                    sb.AppendLine("NOORDER");
                    break;
            }

            switch (obj.Cycle.Key)
            {
                case OracleSequenceCycle.CYCLE:
                    sb.Append("CYCLE");
                    break;
                case OracleSequenceCycle.NOCYCLE:
                    sb.Append("NOCYCLE");
                    break;
            }

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GenerateScript(OracleSequenceModel obj)
        {
            var sb = new StringBuilder();

            sb.AppendLine(GenerateHeader(obj));
            sb.Append    (GenerateObject(obj));
            sb.AppendLine(GenerateFooter(obj));

            return sb.ToString();
        }
    }
}
