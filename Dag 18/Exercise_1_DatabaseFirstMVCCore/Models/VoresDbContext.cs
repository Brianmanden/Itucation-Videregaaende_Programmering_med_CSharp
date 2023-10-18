using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Exercise_1_DatabaseFirstMVCCore.Models;

public partial class VoresDbContext : DbContext
{
    public VoresDbContext()
    {
    }

    public VoresDbContext(DbContextOptions<VoresDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<SalesView> SalesViews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDb; database = VoresDB; integrated security = true; encrypt = false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__Customer__D830D457FF23988A");

            entity.Property(e => e.CId).HasColumnName("cID");
            entity.Property(e => e.CEmail)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('bla@bla.dk')")
                .HasColumnName("cEmail");
            entity.Property(e => e.CName)
                .HasMaxLength(30)
                .HasColumnName("cName");
            entity.Property(e => e.CPhone)
                .HasDefaultValueSql("((12345678))")
                .HasColumnName("cPhone");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OId).HasName("PK__Orders__C2FECB1B1A462FF1");

            entity.Property(e => e.OId).HasColumnName("oID");
            entity.Property(e => e.CId).HasColumnName("cID");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("orderDate");
            entity.Property(e => e.PId).HasColumnName("pID");
            entity.Property(e => e.PaymentStatus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("paymentStatus");
            entity.Property(e => e.Quantity)
                .HasDefaultValueSql("((1))")
                .HasColumnName("quantity");

            entity.HasOne(d => d.CIdNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CId)
                .HasConstraintName("FK__Orders__cID__3D5E1FD2");

            entity.HasOne(d => d.PIdNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.PId)
                .HasConstraintName("FK__Orders__pID__3E52440B");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK__Products__DD36D502667EB558");

            entity.Property(e => e.PId).HasColumnName("pID");
            entity.Property(e => e.PName)
                .HasMaxLength(50)
                .HasColumnName("pName");
            entity.Property(e => e.PPrice)
                .HasDefaultValueSql("((100))")
                .HasColumnName("pPrice");
        });

        modelBuilder.Entity<SalesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesView");

            entity.Property(e => e.CName)
                .HasMaxLength(30)
                .HasColumnName("cName");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("orderDate");
            entity.Property(e => e.PName)
                .HasMaxLength(50)
                .HasColumnName("pName");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(50)
                .HasColumnName("Payment Status");
            entity.Property(e => e.TotalAmount).HasColumnName("Total Amount");
            entity.Property(e => e.UnitPrice).HasColumnName("Unit Price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
