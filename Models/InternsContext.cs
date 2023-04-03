using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAPI_DEMO.Models
{
    public partial class InternsContext : DbContext
    {
        public InternsContext()
        {
        }

        public InternsContext(DbContextOptions<InternsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<PetDetail> PetDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual DbSet<Sbtransaction> Sbtransactions { get; set; }
        public virtual DbSet<SellingDetail> SellingDetails { get; set; }
        public virtual DbSet<SpecsModel> SpecsModels { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TempN> TempNs { get; set; }
        public virtual DbSet<V1> V1s { get; set; }
        public virtual DbSet<V2> V2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HHR16QE\\SQLEXPRESS;Database=Interns;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__customer__B611CB9DC744ACEB");

                entity.ToTable("customer_details");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("customerID");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("customerName");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phoneNO");
            });

            modelBuilder.Entity<PetDetail>(entity =>
            {
                entity.HasKey(e => e.PetId)
                    .HasName("PK__pet_deta__DDF8505907CBDBC2");

                entity.ToTable("pet_details");

                entity.Property(e => e.PetId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("petID");

                entity.Property(e => e.AgeInDays).HasColumnName("ageInDays");

                entity.Property(e => e.Breed)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("breed");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.PetName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("petName");

                entity.Property(e => e.PetType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("petType");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__DD37D91A672E51FD");

                entity.ToTable("Product");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Dom)
                    .HasColumnType("date")
                    .HasColumnName("dom")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasDefaultValueSql("((5000))");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Suppid).HasColumnName("suppid");

                entity.HasOne(d => d.Supp)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Suppid)
                    .HasConstraintName("FK__Product__suppid__398D8EEE");
            });

            modelBuilder.Entity<PurchaseDetail>(entity =>
            {
                entity.HasKey(e => e.PurchaseId)
                    .HasName("PK__purchase__0261224CA9154AB5");

                entity.ToTable("purchase_details");

                entity.Property(e => e.PurchaseId)
                    .ValueGeneratedNever()
                    .HasColumnName("purchaseID");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("customerID");

                entity.Property(e => e.PetId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("petID");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("date")
                    .HasColumnName("purchaseDate");

                entity.Property(e => e.TotalAmountPaid)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("totalAmountPaid");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__purchase___custo__5FB337D6");

                entity.HasOne(d => d.Pet)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.PetId)
                    .HasConstraintName("FK__purchase___petID__60A75C0F");
            });

            modelBuilder.Entity<Sbtransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sbtransaction");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TransactionId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SellingDetail>(entity =>
            {
                entity.HasKey(e => e.BillNumber)
                    .HasName("PK__Selling___C4BBE0C75173EAA9");

                entity.ToTable("Selling_Details");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.ModelNumberNavigation)
                    .WithMany(p => p.SellingDetails)
                    .HasForeignKey(d => d.ModelNumber)
                    .HasConstraintName("FK__Selling_D__Model__6442E2C9");
            });

            modelBuilder.Entity<SpecsModel>(entity =>
            {
                entity.HasKey(e => e.ModelNumber)
                    .HasName("PK__Specs_Mo__6422901EF754102A");

                entity.ToTable("Specs_Model");

                entity.Property(e => e.ModelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LensPower).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SpecsType)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__student__DDDFDD36B4CEFACB");

                entity.ToTable("student");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("sid");

                entity.Property(e => e.Mark).HasColumnName("mark");

                entity.Property(e => e.Sname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("sname");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__supplier__DDDFDD36A7EFB2E7");

                entity.ToTable("supplier");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("sid");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Sname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sname");
            });

            modelBuilder.Entity<TempN>(entity =>
            {
                entity.ToTable("tempN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<V1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v1");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Sname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sname");
            });

            modelBuilder.Entity<V2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v2");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Suppid).HasColumnName("suppid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
