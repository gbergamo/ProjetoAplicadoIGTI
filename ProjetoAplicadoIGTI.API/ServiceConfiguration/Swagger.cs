using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace ProjetoAplicadoIGTI.API.ServiceConfiguration
{
    public static class Swagger
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Projeto Aplicado IGTI",
                    Version = "v1",
                    Description = "Projeto Aplicado IGTI",
                    Contact = new OpenApiContact
                    {
                        Name = "Gustavo Bergamo"
                    }
                });
            });
        }
    }
}
