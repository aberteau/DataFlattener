using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataFlattener.Core;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace DataFlattener.WebApp.Server.Controllers
{
    [Route("[controller]")]
    public class DataTableController : Controller
    {
        [HttpPost("[action]")]
        [ProducesResponseType(typeof(String), StatusCodes.Status200OK)]
        public IActionResult Get([FromBody] String json)
        {
            string jsonOutput = InnerGet(json);
            return Ok(jsonOutput);
        }

        private static string InnerGet(string json)
        {
            DataTableMap dataTableMap = DataTableMapFactory.CreateTestMap();

            Json.DataMapper dataMapper = new Json.DataMapper();
            DataTable dataTable = dataMapper.ToDataTable(json, dataTableMap);

            Json.DataTableConverter dataTableJsonConverter = new Json.DataTableConverter();
            string jsonOutput = dataTableJsonConverter.ToString(dataTable);
            return jsonOutput;
        }

        [HttpPost("[action]")]
        [ProducesResponseType(typeof(String), StatusCodes.Status200OK)]
        public IActionResult GetAsString([FromBody] String json)
        {
            string jsonOutput = InnerGet(json);
            string rawJson = JsonConvert.SerializeObject(jsonOutput);
            return Ok(rawJson);
        }
    }
}
