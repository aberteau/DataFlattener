using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataFlattener.WebApp.Shared;

namespace DataFlattener.WebApp.Client.ViewModels
{
    public interface IFetchDataViewModel
        : IViewModel
    {
        string Json { get; }
        String Source { get; set; }
        IEnumerable<DataColumnMap> Columns { get; }
        Task OnValidSubmit();
    }
}