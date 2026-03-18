using Microsoft.EntityFrameworkCore;
using Product.Persistence.Entities;

namespace Product.Persistence.Context
{
    internal class ProductDbContext : DbContext
    {
        internal ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
            
        }



        internal DbSet<Products> Products { get; set; }    

        internal DbSet<Order> Orders { get; set; }
    }
}
