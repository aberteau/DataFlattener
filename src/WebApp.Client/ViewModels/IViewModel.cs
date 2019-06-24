using System.ComponentModel;
using System.Threading.Tasks;

namespace DataFlattener.WebApp.Client.ViewModels
{
    public interface IViewModel
        : INotifyPropertyChanged
    {
        Task OnViewInitAsync();
    }
}
