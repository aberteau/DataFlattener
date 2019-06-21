using System.Data;
using Newtonsoft.Json;

namespace DataFlattener.Json
{
    public class ConvertHelper
    {
        public static string ToJson(DataTable table)
        {
            string jsonString = JsonConvert.SerializeObject(table, Formatting.Indented);
            return jsonString;
        }
    }
}
