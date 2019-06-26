using System;
using System.Collections.Generic;
using System.Text;

namespace DataFlattener.Core
{
    public class DataTypeHelper
    {
        public static Type ToSystemType(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Integer:
                    return typeof(Int64);

                case DataType.Float:
                    return typeof(Decimal);

                case DataType.String:
                    return typeof(String);

                case DataType.Boolean:
                    return typeof(Boolean);

                case DataType.Date:
                    return typeof(DateTime);
            }

            return null;
        }
    }
}
