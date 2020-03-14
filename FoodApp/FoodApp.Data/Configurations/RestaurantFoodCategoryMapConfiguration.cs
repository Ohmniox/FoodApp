using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class RestaurantFoodCategoryMapConfiguration : IEntityTypeConfiguration<RestaurantFoodCategoryMap>
    {
        public void Configure(EntityTypeBuilder<RestaurantFoodCategoryMap> modelBuilder)
        {
            modelBuilder.HasKey(k => new { k.FoodCategoryId, k.RestaurantId });
            modelBuilder.Property(p => p.FoodCategoryId).IsRequired();
            modelBuilder.Property(p => p.RestaurantId).IsRequired();
            modelBuilder.HasOne(x => x.FoodCategory).WithMany(x => x.RestaurantFoodCategoryMaps).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.HasOne(x => x.Restaurant).WithMany(x => x.RestaurantFoodCategoryMaps).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

