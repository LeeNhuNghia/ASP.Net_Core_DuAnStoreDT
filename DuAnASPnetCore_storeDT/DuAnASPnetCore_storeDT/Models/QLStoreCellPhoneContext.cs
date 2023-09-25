using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DuAnASPnetCore_storeDT.Models
{
    public partial class QLStoreCellPhoneContext : DbContext
    {
        public QLStoreCellPhoneContext()
        {
        }

        public QLStoreCellPhoneContext(DbContextOptions<QLStoreCellPhoneContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=QLStoreCellPhone;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Tkid)
                    .HasName("PK__Account__A0B013F71ADE28AA");

                entity.ToTable("Account");

                entity.Property(e => e.Tkid).HasColumnName("TKID");

                entity.Property(e => e.LoaiTaiKhoan).HasMaxLength(20);

                entity.Property(e => e.Tkdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TKDate");

                entity.Property(e => e.Tkemail)
                    .HasMaxLength(255)
                    .HasColumnName("TKEmail");

                entity.Property(e => e.Tkname)
                    .HasMaxLength(100)
                    .HasColumnName("TKName");

                entity.Property(e => e.Tkpassword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("TKPassword");

                entity.Property(e => e.Tkphone)
                    .HasMaxLength(20)
                    .HasColumnName("TKPhone");

                entity.Property(e => e.Tkusername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TKUsername");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID")
                    .IsFixedLength(true);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.Nccid)
                    .HasName("PK__NhaCungC__B99B10C98D95727A");

                entity.ToTable("NhaCungCap");

                entity.Property(e => e.Nccid)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NCCID")
                    .IsFixedLength(true);

                entity.Property(e => e.Nccaddress)
                    .HasMaxLength(255)
                    .HasColumnName("NCCAddress");

                entity.Property(e => e.Nccemail)
                    .HasMaxLength(255)
                    .HasColumnName("NCCEmail");

                entity.Property(e => e.Nccname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("NCCName");

                entity.Property(e => e.Nccphone)
                    .HasMaxLength(20)
                    .HasColumnName("NCCPhone");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID")
                    .IsFixedLength(true);

                entity.Property(e => e.Nccid)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NCCID")
                    .IsFixedLength(true);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Products__Catego__44FF419A");

                entity.HasOne(d => d.Ncc)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Nccid)
                    .HasConstraintName("FK__Products__NCCID__45F365D3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
