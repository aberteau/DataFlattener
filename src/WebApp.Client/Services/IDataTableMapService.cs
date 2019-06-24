using System;
using System.Threading.Tasks;
using DataFlattener.WebApp.Shared;

namespace DataFlattener.WebApp.Client.Services
{
    public interface IDataTableMapService
    {
        Task<DataTableMap> GetSample01Async();
    }
}