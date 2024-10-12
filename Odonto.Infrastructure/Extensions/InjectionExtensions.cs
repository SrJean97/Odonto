using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Odonto.Domain.IRepositories;
using Odonto.Infrastructure.Persistence.Context;
using Odonto.Infrastructure.Repositories;

namespace Odonto.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection InjectionExtensionInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(OdontoContext).Assembly.FullName;

            services.AddDbContextPool<OdontoContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("OdontoConnection"))
                //, b => b.MigrationsAssembly(assembly)), (int)ServiceLifetime.Transient
            );

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IRepositoryManager, RepositoryManager>();

            return services;
        }
    }
}
