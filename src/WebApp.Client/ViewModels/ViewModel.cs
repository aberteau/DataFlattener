using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DataFlattener.WebApp.Client.ViewModels
{
    public abstract class ViewModel
        : IViewModel
    {
        public virtual async Task OnViewInitAsync()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(String propertyName)
        {
            PropertyChangedEventArgs eventArgs = new PropertyChangedEventArgs(propertyName);
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
