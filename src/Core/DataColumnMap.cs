using System;

namespace DataFlattener.Core
{
    public class DataColumnMap
    {
        public String DataSourcePath { get; }

        public String Name { get; }

        public DataColumnMap(string dataSourcePath, string name)
        {
            DataSourcePath = dataSourcePath;
            Name = name;
        }
    }
}
