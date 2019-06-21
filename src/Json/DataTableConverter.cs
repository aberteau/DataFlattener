using System.Data;
using DataFlattener.Core;

namespace DataFlattener.Json
{
    public class DataTableConverter
        : IDataTableConverter
    {
        public string ToString(DataTable table)
        {
            string jsonString = ConvertHelper.ToJson(table);
            return jsonString;
        }
    }
}
