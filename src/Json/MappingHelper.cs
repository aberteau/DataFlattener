using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataFlattener.Core;
using Newtonsoft.Json.Linq;

namespace DataFlattener.Json
{
    public class MappingHelper
    {
        public static DataTable ToDataTable(String json, DataTableMap tableMap)
        {
            JArray jArray = JArray.Parse(json);

            IEnumerable<JToken> childTokens = jArray.Children();

            DataTable dataTable = new DataTable("Rows");

            foreach (DataColumnMap columnMap in tableMap.Columns)
            {
                Type systemType = DataTypeHelper.ToSystemType(columnMap.DataType);
                dataTable.Columns.Add(columnMap.Name, systemType);
            }

            DataColumnMap[] columnMaps = tableMap.Columns.ToArray();

            foreach (JToken childToken in childTokens)
            {
                object[] values = ToValues(childToken, columnMaps);
                dataTable.Rows.Add(values);
            }

            return dataTable;

        }

        private static object[] ToValues(JToken itemToken, DataColumnMap[] columnMaps)
        {
            IList<object> values = new List<object>();

            foreach (DataColumnMap columnMap in columnMaps)
            {
                JToken jToken = itemToken.SelectToken($"$.{columnMap.DataSourcePath}");
                values.Add(jToken);
            }

            return values.ToArray();
        }
    }
}
