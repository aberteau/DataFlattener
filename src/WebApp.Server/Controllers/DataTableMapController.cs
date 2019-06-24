using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataFlattener.Core;
using Microsoft.AspNetCore.Http;

namespace DataFlattener.WebApp.Server.Controllers
{
    [Route("[controller]")]
    public class DataTableMapController : Controller
    {
        [HttpGet("[action]")]
        [ProducesResponseType(typeof(DataTableMap), StatusCodes.Status200OK)]
        public IActionResult GetSample01()
        {
            DataTableMap dataTableMap = DataTableMapFactory.CreateTestMap();
            return Ok(dataTableMap);
        }
    }
}
