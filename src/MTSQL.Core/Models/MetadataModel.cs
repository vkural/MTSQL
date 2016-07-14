using System.IO;

namespace MTSQL.Core.Models
{
    public class MetadataModel
    {
        public string FullPath { get; set; }

        public string FileName
        {
            get
            {
                return Path.GetFileName(FullPath);
            }
        }

        public override string ToString()
        {
            return FileName;
        }
    }
}
