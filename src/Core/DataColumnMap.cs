using System;

namespace DataFlattener.Core
{
    public class DataColumnMap
    {
        public String DataSourcePath { get; }

        public String Name { get; }

        public DataType DataType { get; }

        public DataColumnMap(string dataSourcePath, string name , DataType dataType)
        {
            DataSourcePath = dataSourcePath;
            Name = name;
            DataType = dataType;
        }
    }
}
