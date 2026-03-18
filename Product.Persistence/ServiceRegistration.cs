using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.Application;
using Product.Domain.Interfaces;
using Product.Persistence.Context;
using Product.Persistence.Repositories;

namespace Product.Persistence
{   
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterPersistence(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(PersistenceApplicationMarker).Assembly);


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
