using Microsoft.EntityFrameworkCore;
using Product_API.Models;

namespace ECommerceAPI.Data
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Product>(product =>
            {
                product.Property(p => p.Active).HasDefaultValue(true);
                product.Property(p => p.CreationDate).HasDefaultValue(DateTime.Now);
                product.Property(p => p.LastUpdate).HasDefaultValue(null);
            });
        }
    }
}
