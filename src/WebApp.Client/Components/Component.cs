using System.ComponentModel;
using System.Threading.Tasks;
using DataFlattener.WebApp.Client.ViewModels;
using Microsoft.AspNetCore.Components;

namespace DataFlattener.WebApp.Client.Components
{
    public class Component<T>
        : ComponentBase
        where T : IViewModel
    {
        [Inject]
        public T ViewModel { get; set; }

        protected override async Task OnInitAsync()
        {
            await base.OnInitAsync();
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
            await ViewModel.OnViewInitAsync();
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            StateHasChanged();
        }
    }
}