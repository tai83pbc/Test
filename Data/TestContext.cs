using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Data;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemFavourite> ItemFavourites { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=WINDOWS-10\\NTTKING;Initial Catalog=Test;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Item__3214EC077FC1F614");

            entity.ToTable("Item");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Desciption).HasMaxLength(250);
            entity.Property(e => e.Image)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<ItemFavourite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Item_Fav__3214EC071FDC2C6A");

            entity.ToTable("Item_Favourite");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
