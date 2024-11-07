using madachiecommerce.InterfaceAdapters.Gateways;
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
