using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EfCore.Models
{
    public partial class WareHouseContext : DbContext
    {
        public WareHouseContext()
        {
        }

        public WareHouseContext(DbContextOptions<WareHouseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Return> Returns { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-GI0C1PC\\SQLEXPRESS;Initial Catalog=WareHouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PK_PRODUCT")
                    .IsClustered(false);

                entity.ToTable("Product");

                entity.HasIndex(e => e.IdWarehouse, "Relationship_1_FK");

                entity.Property(e => e.IdProduct)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Product");

                entity.Property(e => e.BarNumber).HasColumnName("Bar_Number");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IdWarehouse)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Warehouse");

                entity.Property(e => e.PurchaseMethod).HasColumnName("Purchase_Method");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("money")
                    .HasColumnName("Purchase_Price");

                entity.Property(e => e.SellPrice)
                    .HasColumnType("money")
                    .HasColumnName("Sell_Price");

                entity.HasOne(d => d.IdWarehouseNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdWarehouse)
                    .HasConstraintName("FK_PRODUCT_RELATIONS_WAREHOUS");
            });

            modelBuilder.Entity<Return>(entity =>
            {
                entity.HasKey(e => e.IdReturns)
                    .HasName("PK_RETURNS")
                    .IsClustered(false);

                entity.HasIndex(e => e.ProIdProduct, "Relationship_3_FK");

                entity.Property(e => e.IdReturns)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Returns");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.Property(e => e.ProIdProduct)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Pro_Id_Product");

                entity.HasOne(d => d.ProIdProductNavigation)
                    .WithMany(p => p.Returns)
                    .HasForeignKey(d => d.ProIdProduct)
                    .HasConstraintName("FK_RETURNS_RELATIONS_PRODUCT");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.IdSales)
                    .HasName("PK_SALES")
                    .IsClustered(false);

                entity.HasIndex(e => e.ProIdProduct, "Relationship_2_FK");

                entity.Property(e => e.IdSales)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Sales");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.Property(e => e.ProIdProduct)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Pro_Id_Product");

                entity.Property(e => e.Profit).HasColumnType("money");

                entity.HasOne(d => d.ProIdProductNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.ProIdProduct)
                    .HasConstraintName("FK_SALES_RELATIONS_PRODUCT");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK_USERS")
                    .IsClustered(false);

                entity.Property(e => e.IdUser)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_User");

                entity.Property(e => e.Name).HasMaxLength(15);

                entity.Property(e => e.Password)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasKey(e => e.IdWarehouse)
                    .HasName("PK_WAREHOUSE")
                    .IsClustered(false);

                entity.ToTable("Warehouse");

                entity.Property(e => e.IdWarehouse)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Warehouse");

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
