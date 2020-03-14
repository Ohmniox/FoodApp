using FoodApp.Data.Configurations;
using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FoodApp.Data
{
    public class FoodAppDbContext : DbContext
    {
        public FoodAppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelConfiguration(modelBuilder);
        }

        private void ModelConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FoodConfiguration());
            modelBuilder.ApplyConfiguration(new FoodCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new FoodCategoryCustomizationMapConfiguration());
            modelBuilder.ApplyConfiguration(new FoodCustomizationConfiguration());
            modelBuilder.ApplyConfiguration(new FoodCustomizationOptionConfiguration());
            modelBuilder.ApplyConfiguration(new RestaurantConfiguration());
            modelBuilder.ApplyConfiguration(new RestaurantFoodCategoryMapConfiguration());
        }
    }
}
