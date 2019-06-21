using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataFlattener.Core
{
    public interface IDataMapper
    {
        DataTable ToDataTable(String structuredData, DataTableMap tableMap);
    }
}
