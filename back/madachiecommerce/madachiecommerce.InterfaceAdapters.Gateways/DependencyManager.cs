using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.InterfaceAdapters.Gateways.Repositories;
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
            services.AddScoped<ICreateOrderDetailRepository, CreateOrderDetailRepository>();
            services.AddScoped<ICreateOrderHeaderRepository, CreateOrderHeaderRepository>();
            services.AddScoped<IListOrderDetailsRepository, ListOrderDetailsRepository>();
            services.AddScoped<IListOrderHeadersRepository, ListOrderHeadersRepository>();
            services.AddScoped<IListProductsRepository, ListProductsRepository>();
            return services;
        }
    }
}
