using madachiecommerce.ApplicationBusinessRules.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace madachiecommerce.InterfaceAdapters.Controllers;
public static class DependencyManager
{
    public static IServiceCollection AddControllers(this IServiceCollection services) 
    {
        services.AddScoped<ICreateOrderDetailController, CreateOrderDetailController>();
        services.AddScoped<ICreateOrderHeaderController, CreateOrderHeaderController>();
        services.AddScoped<IListOrderDetailsController, ListOrderDetailsController>();
        services.AddScoped<IListOrderHeadersController, ListOrderHeadersController>();
        return services;
    }
}
