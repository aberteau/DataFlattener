using DataFlattener.Core;

namespace DataFlattener.TestConsoleApp
{
    public class DataTableMapFactory
    {
        public static DataTableMap CreateTestMap()
        {
            DataTableMap tableMapping = new DataTableMap();

            tableMapping.Columns.Add(new DataColumnMap("id", "id"));
            tableMapping.Columns.Add(new DataColumnMap("name", "name"));
            tableMapping.Columns.Add(new DataColumnMap("range.start.page", "range_start_page"));
            tableMapping.Columns.Add(new DataColumnMap("range.start.x", "range_start_x"));
            tableMapping.Columns.Add(new DataColumnMap("range.start.y", "range_start_y"));

            tableMapping.Columns.Add(new DataColumnMap("range.end.page", "range_end_page"));
            tableMapping.Columns.Add(new DataColumnMap("range.end.x", "range_end_x"));
            tableMapping.Columns.Add(new DataColumnMap("range.end.y", "range_end_y"));

            return tableMapping;
        }
    }
}
