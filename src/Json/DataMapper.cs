using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataFlattener.Core;
using Newtonsoft.Json.Linq;

namespace DataFlattener.Json
{
    public class DataMapper
        : IDataMapper
    {
        public DataTable ToDataTable(String json, DataTableMap tableMap)
        {
            DataTable dataTable = MappingHelper.ToDataTable(json, tableMap);
            return dataTable;
        }
    }
}
