using Microsoft.EntityFrameworkCore;
using Product.Persistence.Entities;

namespace Product.Persistence.Context
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
            
        }



        public DbSet<Products> Products { get; set; }    

        public DbSet<Order> Orders { get; set; }
    }
}
