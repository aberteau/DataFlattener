using System.Data;
using System.IO;
using CsvHelper;

namespace DataFlattener.Csv
{
    public class ConvertHelper
    {
        public static string ToCsv(DataTable table)
        {
            using (StringWriter sw = new StringWriter())
            using (CsvWriter csv = new CsvWriter(sw))
            {
                foreach (DataColumn column in table.Columns)
                    csv.WriteField(column.ColumnName);

                csv.NextRecord();

                foreach (DataRow row in table.Rows)
                {
                    for (var i = 0; i < table.Columns.Count; i++)
                        csv.WriteField(row[i]);

                    csv.NextRecord();
                }

                string csvString = sw.ToString();
                return csvString;
            }
        }
    }
}
