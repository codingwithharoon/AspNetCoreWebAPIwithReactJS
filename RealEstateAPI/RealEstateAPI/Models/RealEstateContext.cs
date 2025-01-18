using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RealEstateAPI.Models;

public partial class RealEstateContext : DbContext
{
    public RealEstateContext()
    {
    }

    public RealEstateContext(DbContextOptions<RealEstateContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PropertyListing> PropertyListings { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PropertyListing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Property__3214EC07AFA0ED09");

            entity.Property(e => e.PropertyInfo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PropertyType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
