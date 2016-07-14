namespace MTSQL.Generators
{
    public interface IDBObjectScriptGenerator<T> where T : class
    {
        string GenerateHeader(T obj);
        string GenerateFooter(T obj);
        string GenerateObject(T obj);
        string GenerateScript(T obj);
    }
}
