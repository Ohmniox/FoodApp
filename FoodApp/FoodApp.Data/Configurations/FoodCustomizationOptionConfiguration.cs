using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class FoodCustomizationOptionConfiguration : IEntityTypeConfiguration<FoodCustomizationOption>
    {
        public void Configure(EntityTypeBuilder<FoodCustomizationOption> modelBuilder)
        {
            modelBuilder.ToTable("FoodCustomizationOption");
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            modelBuilder.Property(p => p.FoodCustomizationId).IsRequired();
            modelBuilder.Property(p => p.UnitPrice).HasColumnType("decimal(5, 2)").IsRequired();
            modelBuilder.HasOne(x => x.FoodCustomization).WithMany(x => x.FoodCustomizationOptions);
        }
    }
}

