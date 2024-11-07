using madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace madachiecommerce.InterfaceAdapters.Gateways
{
    public static class DependencyManager
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration, string connection)
        {
            services.AddDbContext<>(options => options.UseSqlServer(configuration.GetConnectionString(connectionStringName)));
            services.AddScoped<ICreateOrderDetailRepository>();
            return services;
        }
    }
}
