using Microsoft.Extensions.DependencyInjection;
using ProjetoAplicadoIGTI.ApplicationService.Services.Implementations;
using ProjetoAplicadoIGTI.ApplicationService.Services.Interfaces;

namespace ProjetoAplicadoIGTI.InjectionModule
{
    public static class InjectionAppService
    {
        public static void ConfigureInjectionAppService(this IServiceCollection services)
        {
            services.AddScoped<IAppointmentAppService, AppointmentAppRepository>();
            services.AddScoped<IClientAppService, ClientAppService>();
            services.AddScoped<IProviderAppService, ProviderAppService>();
        }
    }
}
