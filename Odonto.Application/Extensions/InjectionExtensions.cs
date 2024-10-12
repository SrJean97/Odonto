using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Odonto.Application.ServiceAbstraction;
using Odonto.Application.Services;
using System.Reflection;

namespace Odonto.Application.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection InjectionExtensionApplication( this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //services.AddScoped<IServicesApplication, ServicesApplication>();
            services.AddScoped<IServiceManager, ServiceManager>();

            return services;
        }
    }
}
