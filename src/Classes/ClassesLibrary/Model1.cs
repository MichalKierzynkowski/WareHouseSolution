using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ClassesLibrary
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Returns> Returns { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.IdProduct)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.IdWarehouse)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.PurchasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.SellPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Returns)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.ProIdProduct);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Sales)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.ProIdProduct);

            modelBuilder.Entity<Returns>()
                .Property(e => e.IdReturns)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Returns>()
                .Property(e => e.ProIdProduct)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales>()
                .Property(e => e.IdSales)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales>()
                .Property(e => e.ProIdProduct)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales>()
                .Property(e => e.Profit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Users>()
                .Property(e => e.IdUser)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.IdWarehouse)
                .HasPrecision(18, 0);
        }
    }
}
