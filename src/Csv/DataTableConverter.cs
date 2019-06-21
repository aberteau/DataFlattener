using System.Data;
using DataFlattener.Core;

namespace DataFlattener.Csv
{
    public class DataTableConverter
        : IDataTableConverter
    {
        public string ToString(DataTable table)
        {
            string csvString = ConvertHelper.ToCsv(table);
            return csvString;
        }
    }
}
