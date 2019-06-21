using System.Data;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace DataFlattener.Xml
{
    public class ConvertHelper
    {
        public static string ToXml(DataTable table)
        {
            using (StringWriter sw = new StringWriter())
            {
                table.WriteXml(sw);
                string xmlString = sw.ToString();
                return xmlString;
            }
        }
    }
}
