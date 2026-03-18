using Microsoft.Extensions.DependencyInjection;
using Product.Application.Concrete;
using Product.Application.Interfaces;

namespace Product.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ApplicationAssemblyMarker).Assembly);

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();

            return services;
        }
    }
}
