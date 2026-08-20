using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CarLibrary.Entities;

public partial class AutoLotContext : DbContext
{
    public AutoLotContext()
    {
    }

    public AutoLotContext(DbContextOptions<AutoLotContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CreditRisk> CreditRisks { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<InventoryWithMake> InventoryWithMakes { get; set; }

    public virtual DbSet<Make> Makes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

	public virtual DbSet<Car> Cars { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AutoLot;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CreditRisk>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_CreditRisks_CustomerId");

            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);

            entity.HasOne(d => d.Customer).WithMany(p => p.CreditRisks)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CreditRisks_Customers");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.ToTable("Inventory");

            entity.HasIndex(e => e.MakeId, "IX_Inventory_MakeId");

            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.PetName).HasMaxLength(50);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Make).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.MakeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Makes");
        });

        modelBuilder.Entity<InventoryWithMake>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("InventoryWithMakes");

            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.Make).HasMaxLength(50);
            entity.Property(e => e.PetName).HasMaxLength(50);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Make>(entity =>
        {
            entity.HasIndex(e => e.Name, "UQ_Makes_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasIndex(e => e.CarId, "IX_Orders_CarId");

            entity.HasIndex(e => new { e.CarId, e.CustomerId }, "IX_Orders_CarId_CustomerId");

            entity.HasIndex(e => e.CustomerId, "IX_Orders_CustomerId");

            entity.HasOne(d => d.Car).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Inventory");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Orders_Customers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
