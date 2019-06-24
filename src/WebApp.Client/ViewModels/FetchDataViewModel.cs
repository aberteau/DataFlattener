using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DataFlattener.WebApp.Client.Services;
using DataFlattener.WebApp.Shared;

namespace DataFlattener.WebApp.Client.ViewModels
{
    public class FetchDataViewModel
        : ViewModel, IFetchDataViewModel
    {
        private readonly IDataTableService _dataTableService;
        private readonly IDataTableMapService _dataTableMapService;

        private string _json;
        private IEnumerable<DataColumnMap> _columns;

        public string Json
        {
            get => _json;
            private set { _json = value; RaisePropertyChanged(nameof(Json));}
        }

        public IEnumerable<DataColumnMap> Columns
        {
            get => _columns;
            private set
            {
                _columns = value;
                RaisePropertyChanged(nameof(DataTableMap));
            } 
        }

        public string Source { get; set; }

        public override async Task OnViewInitAsync()
        {
            await base.OnViewInitAsync();
            DataTableMap dataTableMap = await _dataTableMapService.GetSample01Async();
            Columns = dataTableMap.Columns;
        }

        public async Task OnValidSubmit()
        {

            Json = await _dataTableService.GetAsStringAsync(Source);
        }

        public FetchDataViewModel(IDataTableService dataTableService, IDataTableMapService dataTableMapService)
        {
            _dataTableService = dataTableService;
            _dataTableMapService = dataTableMapService;
        }
    }
}
