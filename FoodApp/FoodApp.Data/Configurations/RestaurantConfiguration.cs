using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> modelBuilder)
        {
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property(p => p.Name).IsRequired().HasMaxLength(200);
        }
    }
}

