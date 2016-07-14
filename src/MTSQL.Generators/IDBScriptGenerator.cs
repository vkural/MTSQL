using MTSQL.Core.Models.Metadata;
using System.Collections.Generic;
using System.IO;

namespace MTSQL.Generators
{
    public interface IDBScriptGenerator
    {
        string GenerateScript(List<MemoryStream> streams  );
        string GenerateScript(List<string>       fileNames);
    }
}