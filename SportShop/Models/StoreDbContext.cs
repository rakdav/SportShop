using Microsoft.EntityFrameworkCore;

namespace SportShop.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products=>Set<Product>();
    }
}
