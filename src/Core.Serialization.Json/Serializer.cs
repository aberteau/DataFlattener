using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace DataFlattener.Core.Serialization.Json
{
    public class Serializer
    {
        public static string Serialize(IEnumerable<DataColumnMap> dataColumnMaps)
        {
            IEnumerable<Data.DataColumnMap> dataColums = dataColumnMaps.Select(c => MapToData(c)).ToList();
            string jsonString = JsonConvert.SerializeObject(dataColums, Formatting.Indented);
            return jsonString;
        }

        public static DataColumnMap[] Deserialize(String json)
        {
            Data.DataColumnMap[] dataColums = JsonConvert.DeserializeObject<Data.DataColumnMap[]>(json);
            DataColumnMap[]  columns = dataColums.Select(c => MapToCore(c)).ToArray();
            return columns;
        }

        private static Data.DataColumnMap MapToData(DataColumnMap datacolumnMap)
        {
            Data.DataColumnMap dto = new Data.DataColumnMap();
            dto.DataSourcePath = datacolumnMap.DataSourcePath;
            dto.Name = datacolumnMap.Name;
            dto.DataType = datacolumnMap.DataType.ToString();
            return dto;
        }

        private static DataColumnMap MapToCore(Data.DataColumnMap datacolumnMap)
        {
            DataType dataType = MapToCore(datacolumnMap.DataType);
            DataColumnMap map = new DataColumnMap(datacolumnMap.DataSourcePath, datacolumnMap.Name, dataType);
            return map;
        }

        private static DataType MapToCore(string dataType)
        {
            return (DataType)Enum.Parse(typeof(DataType), dataType);
        }
    }
}
