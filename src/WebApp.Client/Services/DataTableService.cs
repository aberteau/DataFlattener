using System;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace DataFlattener.WebApp.Client.Services
{
    public class DataTableService
        : IDataTableService
    {
        private readonly HttpClient _httpClient;
        private readonly string _controllerName = "DataTable";

        public DataTableService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<String> GetAsync(String json)
        {
            string requestUri = $"{_controllerName}/Get";
            String str = await _httpClient.PostJsonAsync<String>(requestUri, json);
            return str;
        }

        public async Task<String> GetAsStringAsync(String json)
        {
            string requestUri = $"{_controllerName}/GetAsString";
            String str = await _httpClient.PostJsonAsync<String>(requestUri, json);
            return str;
        }
    }
}
