using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class WareHouseDbContext : DbContext
    {
        public WareHouseDbContext(DbContextOptions options) : base(options)
        {
        }

        public WareHouseDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\Michal\source\repos\MichalKierzynkowski\WareHouseSolution\src\WareHouseApplication\WareHouse.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .HasOne(x => x.ProductDetail)
            .WithOne(x => x.Product)
            .HasForeignKey<ProductDetail>(c => c.ProductId);

            modelBuilder.Entity<ProductDetail>().HasKey(s => s.Id);
        }
    }
}