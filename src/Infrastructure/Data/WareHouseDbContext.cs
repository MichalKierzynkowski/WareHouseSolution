using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;

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
        public DbSet<WareHouse> WareHouse { get; set; }
        public DbSet<Return> Returns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\michu\source\repos\I4BWorkspace\WareHouseSolution\src\WareHouseApplication\WareHouse.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WareHouse>().Navigation(e => e.Products).AutoInclude();
            modelBuilder.Entity<Product>().Navigation(e => e.ProductDetail).AutoInclude();
            modelBuilder.Entity<Return>().Navigation(e => e.Products).AutoInclude();
        }
    }
}