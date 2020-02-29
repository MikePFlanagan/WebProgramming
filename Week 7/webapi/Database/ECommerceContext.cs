using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)         
        {         
        }
        
        public DbSet<Product> Product { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
    }
}