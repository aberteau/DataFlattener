using System;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using DataFlattener.WebApp.Shared;
using Microsoft.AspNetCore.Components;

namespace DataFlattener.WebApp.Client.Services
{
    public class DataTableMapService
        : IDataTableMapService
    {
        private readonly HttpClient _httpClient;
        private readonly string _controllerName = "DataTableMap";

        public DataTableMapService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<DataTableMap> GetSample01Async()
        {
            string requestUri = $"{_controllerName}/GetSample01";
            try
            {
                DataTableMap dataTableMap = await _httpClient.GetJsonAsync<DataTableMap>(requestUri);
                return dataTableMap;
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
