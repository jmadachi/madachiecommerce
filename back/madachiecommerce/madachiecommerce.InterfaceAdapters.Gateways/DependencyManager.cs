using madachiecommerce.ApplicationBusinessRules.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace madachiecommerce.InterfaceAdapters.Gateways
{
    public static class DependencyManager
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration, string connectionDataBase)
        {
            services.AddDbContext<madachiecommerceContext>(options => options.UseSqlServer(configuration.GetConnectionString(connectionDataBase)));
            services.AddScoped<ICreateOrderDetailRepository>();
            return services;
        }
    }
}
