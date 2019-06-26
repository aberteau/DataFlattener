using System;
using Newtonsoft.Json;

namespace DataFlattener.Core.Serialization.Json.Data
{
    public class DataColumnMap
    {
        [JsonProperty("dataSourcePath")]
        public String DataSourcePath { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("dataType")]
        public String DataType { get; set; }
    }
}
