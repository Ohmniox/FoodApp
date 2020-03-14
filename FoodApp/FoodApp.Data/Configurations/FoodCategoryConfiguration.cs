using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class FoodCategoryConfiguration : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> modelBuilder)
        {
            modelBuilder.ToTable("FoodCategory");
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property(p => p.Name).IsRequired().HasMaxLength(200);
        }
    }
}

