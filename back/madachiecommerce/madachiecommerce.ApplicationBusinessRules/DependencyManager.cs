using madachiecommerce.ApplicationBusinessRules.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace madachiecommerce.ApplicationBusinessRules.UseCases;
public static class DependencyManager
{
    public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateOrderDetailInputPort, CreateOrderDetailInteractor>();
        services.AddScoped<ICreateOrderHeaderInputPort, CreateOrderHeaderInteractor>();
        services.AddScoped<IListOrderDetailsInputPort, ListOrderDetailsInteractor>();
        services.AddScoped<IListOrderHeadersInputPort, ListOrderHeadersInteractor>();
        services.AddScoped<IListProductsInputPort, ListProductsInteractor>();
        services.AddScoped<ILoginInputPort, LoginInteractor>();
        return services;
    }
}
