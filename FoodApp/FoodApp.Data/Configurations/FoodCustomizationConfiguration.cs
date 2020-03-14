using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class FoodCustomizationConfiguration : IEntityTypeConfiguration<FoodCustomization>
    {
        public void Configure(EntityTypeBuilder<FoodCustomization> modelBuilder)
        {
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            modelBuilder.Property(p => p.CanSelectMultipleOptions).IsRequired();
        }
    }
}

