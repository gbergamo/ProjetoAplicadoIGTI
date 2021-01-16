using Microsoft.Extensions.DependencyInjection;
using ProjetoAplicadoIGTI.Repository.Repository.Implementation;
using ProjetoAplicadoIGTI.Repository.Repository.Interfaces;

namespace ProjetoAplicadoIGTI.InjectionModule
{
    public static class InjectionRepository
    {
        public static void ConfigureInjectionRepository(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository, BaseRepository>();

            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
        }
    }
}
