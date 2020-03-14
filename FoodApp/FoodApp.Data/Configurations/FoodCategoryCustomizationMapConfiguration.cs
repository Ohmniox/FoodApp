using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class FoodCategoryCustomizationMapConfiguration : IEntityTypeConfiguration<FoodCategoryCustomizationMap>
    {
        public void Configure(EntityTypeBuilder<FoodCategoryCustomizationMap> modelBuilder)
        {
            modelBuilder.ToTable("FoodCategoryCustomization");
            modelBuilder.Property(p => p.FoodCategoryId).IsRequired();
            modelBuilder.Property(p => p.FoodCustomizationId).IsRequired();
            modelBuilder.HasKey(k => new { k.FoodCategoryId, k.FoodCustomizationId });
            modelBuilder.HasOne(x => x.FoodCategory).WithMany(x => x.FoodCategoryCustomizationMaps).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.HasOne(x => x.FoodCustomization).WithMany(x => x.FoodCategoryCustomizationMaps).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

