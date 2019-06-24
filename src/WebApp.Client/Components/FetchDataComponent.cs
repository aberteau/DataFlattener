using System.Threading.Tasks;
using DataFlattener.WebApp.Client.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Layouts;

namespace DataFlattener.WebApp.Client.Components
{
    public class FetchDataComponent
        : Component<IFetchDataViewModel>
    {
        protected override async Task OnInitAsync()
        {
            await ViewModel.OnViewInitAsync();
        }
    }
}
