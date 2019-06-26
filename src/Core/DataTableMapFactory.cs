using System.Collections.Generic;

namespace DataFlattener.Core
{
    public class DataTableMapFactory
    {
        public static DataTableMap CreateTestMap()
        {
            DataTableMap tableMap = new DataTableMap();
            tableMap.Columns = new List<DataColumnMap>()
            {
                new DataColumnMap("id", "id", DataType.String),
                new DataColumnMap("name", "name", DataType.String),
                new DataColumnMap("range.start.page", "range_start_page", DataType.Integer),
                new DataColumnMap("range.start.x", "range_start_x", DataType.Float),
                new DataColumnMap("range.start.y", "range_start_y", DataType.Float),

                new DataColumnMap("range.end.page", "range_end_page", DataType.Integer),
                new DataColumnMap("range.end.x", "range_end_x", DataType.Float),
                new DataColumnMap("range.end.y", "range_end_y", DataType.Float)
            };

            return tableMap;
        }
    }
}
