using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> modelBuilder)
        {
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            modelBuilder.Property(p => p.FoodCategoryId).IsRequired();
            modelBuilder.Property(p => p.UnitPrice).HasColumnType("decimal(5, 2)").IsRequired();
            modelBuilder.HasOne(x => x.FoodCategory).WithMany(x => x.Foods);
        }
    }
}

