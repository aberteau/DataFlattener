using System.Collections.Generic;

namespace DataFlattener.Core
{
    public class DataTableMap
    {
        public IList<DataColumnMap> Columns { get; } = new List<DataColumnMap>();
    }
}