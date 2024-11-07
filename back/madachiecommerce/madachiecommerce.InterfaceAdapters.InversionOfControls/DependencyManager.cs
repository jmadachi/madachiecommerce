using madachiecommerce.ApplicationBusinessRules.UseCases;
using madachiecommerce.InterfaceAdapters.Gateways;
using madachiecommerce.InterfacesAdapters.Presenters;
using madachiecommerce.InterfaceAdapters.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace madachiecommerce.InterfaceAdapters.InversionOfControls;
public static class DependencyManager
{
    public static IServiceCollection AddAppServices(this IServiceCollection services,IConfiguration configuration,string connectionStringName)
    {
        services
            .AddRepositories(configuration, connectionStringName)
            .AddUseCasesServices()
            .AddPresenters()
            .AddControllers();
        return services;
    }
}
