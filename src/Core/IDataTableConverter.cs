using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataFlattener.Core
{
    public interface IDataTableConverter
    {
        string ToString(DataTable table);
    }
}
