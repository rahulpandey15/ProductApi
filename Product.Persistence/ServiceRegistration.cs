using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.Domain.Interfaces;
using Product.Persistence.Concrete;
using Product.Persistence.Context;

namespace Product.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterPersistence(
            this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDbContext<ProductDbContext>(
               options =>
               {
                   options.UseSqlServer(configuration.GetConnectionString("DatabaseConnection"));
               });


            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}
