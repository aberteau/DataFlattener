using System.Data;
using DataFlattener.Core;

namespace DataFlattener.Xml
{
    public class DataTableConverter
        : IDataTableConverter
    {
        public string ToString(DataTable table)
        {
            string xmlString = ConvertHelper.ToXml(table);
            return xmlString;
        }
    }
}
