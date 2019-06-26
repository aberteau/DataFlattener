namespace DataFlattener.Core
{
    public class DataTableMapFactory
    {
        public static DataTableMap CreateTestMap()
        {
            DataTableMap tableMapping = new DataTableMap();

            tableMapping.Columns.Add(new DataColumnMap("id", "id", DataType.String));
            tableMapping.Columns.Add(new DataColumnMap("name", "name", DataType.String));
            tableMapping.Columns.Add(new DataColumnMap("range.start.page", "range_start_page", DataType.Integer));
            tableMapping.Columns.Add(new DataColumnMap("range.start.x", "range_start_x", DataType.Float));
            tableMapping.Columns.Add(new DataColumnMap("range.start.y", "range_start_y", DataType.Float));

            tableMapping.Columns.Add(new DataColumnMap("range.end.page", "range_end_page", DataType.Integer));
            tableMapping.Columns.Add(new DataColumnMap("range.end.x", "range_end_x", DataType.Float));
            tableMapping.Columns.Add(new DataColumnMap("range.end.y", "range_end_y", DataType.Float));

            return tableMapping;
        }
    }
}
