using madachiecommerce.ApplicationBusinessRules.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace madachiecommerce.ApplicationBusinessRules.UseCases;
public static class DependencyManager
{
    public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateOrderDetailInputPort, CreateOrderDetailUseCase>();
        services.AddScoped<ICreateOrderHeaderInputPort, CreateOrderHeaderUseCase>();
        services.AddScoped<IListOrderDetailsInputPort, ListOrderDetailsUseCase>();
        services.AddScoped<IListOrderHeadersInputPort, ListOrderHeadersUseCase>();
        services.AddScoped<IListProductsInputPort, ListProductsUseCase>();
        services.AddScoped<ILoginInputPort, LoginUseCase>();
        return services;
    }
}
