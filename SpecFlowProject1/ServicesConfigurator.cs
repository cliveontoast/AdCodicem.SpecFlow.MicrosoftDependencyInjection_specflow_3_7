using AdCodicem.SpecFlow.MicrosoftDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MsInjectionSite31;

namespace SpecFlowProject1
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ValuesController>();
        }
    }
}
