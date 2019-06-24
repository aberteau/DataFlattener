using System;
using System.Threading.Tasks;

namespace DataFlattener.WebApp.Client.Services
{
    public interface IDataTableService
    {
        Task<String> GetAsync(String json);
        Task<String> GetAsStringAsync(String json);
    }
}