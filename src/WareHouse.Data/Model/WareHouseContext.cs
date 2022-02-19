using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WareHouse.Data.Model
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

        public virtual DbSet<BuyingPriceChanging> BuyingPriceChangings { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductType> ProductTypes { get; set; } = null!;
        public virtual DbSet<Purchase> Purchases { get; set; } = null!;
        public virtual DbSet<PurchaseMethod> PurchaseMethods { get; set; } = null!;
        public virtual DbSet<Return> Returns { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SellingPriceChanging> SellingPriceChangings { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-GI0C1PC\\SQLEXPRESS;" +
                                            "Initial Catalog=WareHouse;Integrated Security=True;" +
                                            "Encrypt=False;TrustServerCertificate=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuyingPriceChanging>(entity =>
            {
                entity.HasKey(e => e.IdPrice)
                    .HasName("PK__Price_Ch__13FF7BF20F85FD58");

                entity.ToTable("Buying_Price_Changing");

                entity.Property(e => e.IdPrice).HasColumnName("Id_Price");

                entity.Property(e => e.DatePriceChanged)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Price_Changed");

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.BuyingPriceChangings)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Price_Cha__Id_Pr__5CD6CB2B");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PK__Product__6B19B3E7F5DD6746");

                entity.ToTable("Product");

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.Property(e => e.BarNumber).HasColumnName("Bar_Number");

                entity.Property(e => e.DescriptionProduct)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Description_Product");

                entity.Property(e => e.IsReturned)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OfferPrice).HasColumnName("Offer_Price");

                entity.Property(e => e.PurchaseMethod).HasColumnName("Purchase_Method");

                entity.Property(e => e.TypeProduct).HasColumnName("Type_Product");

                entity.HasOne(d => d.PurchaseMethodNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.PurchaseMethod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__Purchas__6CD828CA");

                entity.HasOne(d => d.TypeProductNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.TypeProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__Type_Pr__3B40CD36");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.HasKey(e => e.TypeProduct)
                    .HasName("PK__Product___0AE0A2F9B8A41457");

                entity.ToTable("Product_Type");

                entity.HasIndex(e => e.ProductTypeDescription, "UQ__Product___41917908A52B8715")
                    .IsUnique();

                entity.Property(e => e.TypeProduct)
                    .ValueGeneratedNever()
                    .HasColumnName("Type_Product");

                entity.Property(e => e.ProductTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Product_Type_Description");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasKey(e => e.IdPurchase)
                    .HasName("PK__Purchase__DCFE25070AA2F635");

                entity.ToTable("Purchase");

                entity.Property(e => e.IdPurchase).HasColumnName("Id_Purchase");

                entity.Property(e => e.DatePurchase)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Purchase");

                entity.Property(e => e.FromProductCreate)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("From_Product_Create");

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Purchase__Id_Pro__5FB337D6");
            });

            modelBuilder.Entity<PurchaseMethod>(entity =>
            {
                entity.HasKey(e => e.PurchaseMethod1)
                    .HasName("PK__Purchase__C3A06947C1DE8EB5");

                entity.ToTable("Purchase_Methods");

                entity.HasIndex(e => e.PurchaseMethodDescription, "UQ__Purchase__7E84CDA8C02FA8B3")
                    .IsUnique();

                entity.Property(e => e.PurchaseMethod1)
                    .ValueGeneratedNever()
                    .HasColumnName("Purchase_Method");

                entity.Property(e => e.PurchaseMethodDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Purchase_Method_Description");
            });

            modelBuilder.Entity<Return>(entity =>
            {
                entity.HasKey(e => e.IdReturns)
                    .HasName("PK__Returns__961EDEEDF8F6ACC8");

                entity.Property(e => e.IdReturns).HasColumnName("Id_Returns");

                entity.Property(e => e.DateReturns)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Returns");

                entity.Property(e => e.IdSales).HasColumnName("Id_Sales");

                entity.HasOne(d => d.IdSalesNavigation)
                    .WithMany(p => p.Returns)
                    .HasForeignKey(d => d.IdSales)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Returns__Id_Sale__59FA5E80");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.IdSales)
                    .HasName("PK__Sales__0760C391D08180C5");

                entity.Property(e => e.IdSales).HasColumnName("Id_Sales");

                entity.Property(e => e.DateSales)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Sales");

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sales__Id_Produc__49C3F6B7");
            });

            modelBuilder.Entity<SellingPriceChanging>(entity =>
            {
                entity.HasKey(e => e.IdPrice)
                    .HasName("PK__Selling___13FF7BF2E1F64CD5");

                entity.ToTable("Selling_Price_Changing");

                entity.Property(e => e.IdPrice)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Price");

                entity.Property(e => e.DatePriceChanged)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Price_Changed");

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.SellingPriceChangings)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Selling_P__Id_Pr__5CD6CB2B");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUsers)
                    .HasName("PK__USers__FB0668EED6E9345F");

                entity.Property(e => e.IdUsers).HasColumnName("Id_Users");

                entity.Property(e => e.LoginUser)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Login_User");

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Password_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
