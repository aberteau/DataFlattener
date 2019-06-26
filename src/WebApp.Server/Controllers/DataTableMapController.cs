using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataFlattener.WebApp.Shared;
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
            Core.DataTableMap tableMap = Core.DataTableMapFactory.CreateTestMap();
            DataTableMap mapDto = MapToApiDto(tableMap);
            return Ok(mapDto);
        }

        private DataTableMap MapToApiDto(Core.DataTableMap dataTableMap)
        {
            DataTableMap dto = new DataTableMap();
            dto.Columns = dataTableMap.Columns.Select(c => MapToApiDto(c)).ToList();
            return dto;
        }

        private DataColumnMap MapToApiDto(Core.DataColumnMap datacolumnMap)
        {
            DataColumnMap dto = new DataColumnMap();
            dto.DataSourcePath = datacolumnMap.DataSourcePath;
            dto.Name = datacolumnMap.DataSourcePath;
            dto.DataType = datacolumnMap.DataType.ToString();
            return dto;
        }
    }
}
