using DataFlattener.WebApp.Client.Services;
using DataFlattener.WebApp.Client.ViewModels;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DataFlattener.WebApp.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDataTableService, DataTableService>();
            services.AddSingleton<IDataTableMapService, DataTableMapService>();

            services.AddTransient<IFetchDataViewModel, FetchDataViewModel>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
