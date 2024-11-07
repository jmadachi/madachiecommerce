using madachiecommerce.ApplicationBusinessRules.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace madachiecommerce.InterfacesAdapters.Presenters
{
    public static class DependencyManager
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services) 
        {
            services.AddScoped<CreateOrderDetailPresenter>();
            services.AddScoped<CreateOrderHeaderPresenter>();
            services.AddScoped<ListOrderHeadersPresenter>();
            services.AddScoped<ListOrderDetailsPresenter>();

            services.AddScoped<ICreateOrderDetailOutputPort>(provider => provider.GetService<CreateOrderDetailPresenter>());
            services.AddScoped<ICreateOrderHeaderOutputPort>(provider => provider.GetService<CreateOrderHeaderPresenter>());
            services.AddScoped<IListOrderHeadersOutputPort>(provider => provider.GetService<ListOrderHeadersPresenter>());
            services.AddScoped<IListOrderDetailsOutputPort>(provider => provider.GetService<ListOrderDetailsPresenter>());

            services.AddScoped<ICreateOrderDetailPresenter>(provider => provider.GetService<CreateOrderDetailPresenter>());
            services.AddScoped<ICreateOrderHeaderPresenter>(provider => provider.GetService<CreateOrderHeaderPresenter>());
            services.AddScoped<IListOrderDetailsPresenter>(provider => provider.GetService<ListOrderDetailsPresenter>());
            services.AddScoped<IListOrderHeadersPresenter>(provider => provider.GetService<ListOrderHeadersPresenter>());

            return services;
        }
    }
}
