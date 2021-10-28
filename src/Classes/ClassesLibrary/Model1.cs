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
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Id_Product)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.Id_Warehouse)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.Purchase_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Sell_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Returns)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Pro_Id_Product);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Sales)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Pro_Id_Product);

            modelBuilder.Entity<Returns>()
                .Property(e => e.Id_Returns)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Returns>()
                .Property(e => e.Pro_Id_Product)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales>()
                .Property(e => e.Id_Sales)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales>()
                .Property(e => e.Pro_Id_Product)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales>()
                .Property(e => e.Profit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Users>()
                .Property(e => e.Id_User)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Id_Warehouse)
                .HasPrecision(18, 0);
        }
    }
}
