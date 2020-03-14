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
            SeedData(modelBuilder);
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

        private void SeedData(ModelBuilder modelBuilder)
        {
            var resMcD = new Restaurant { Id = Guid.NewGuid(), Name = "McD" };
            var resPizzaHut = new Restaurant { Id = Guid.NewGuid(), Name = "Pizza Hut" };
            var resSandExpress = new Restaurant { Id = Guid.NewGuid(), Name = "Sandwich Express" };
            modelBuilder.Entity<Restaurant>().HasData(resMcD, resPizzaHut, resSandExpress);

            var fCPizza = new FoodCategory { Id = Guid.NewGuid(), Name = "Pizza" };
            var fCSandwiches = new FoodCategory { Id = Guid.NewGuid(), Name = "Sandwiches" };
            var fCDrinks = new FoodCategory { Id = Guid.NewGuid(), Name = "Drinks" };
            modelBuilder.Entity<FoodCategory>().HasData(fCPizza, fCSandwiches, fCDrinks);

            var restaurantFoodCategoryMapList = new List<RestaurantFoodCategoryMap>
            {
                new RestaurantFoodCategoryMap { FoodCategoryId = fCSandwiches.Id, RestaurantId = resMcD.Id },
                new RestaurantFoodCategoryMap { FoodCategoryId = fCPizza.Id, RestaurantId = resMcD.Id },
                new RestaurantFoodCategoryMap { FoodCategoryId = fCDrinks.Id, RestaurantId = resMcD.Id },

                new RestaurantFoodCategoryMap { FoodCategoryId = fCPizza.Id, RestaurantId = resPizzaHut.Id },
                new RestaurantFoodCategoryMap { FoodCategoryId = fCDrinks.Id, RestaurantId = resPizzaHut.Id },

                new RestaurantFoodCategoryMap { FoodCategoryId = fCSandwiches.Id, RestaurantId = resSandExpress.Id },
                new RestaurantFoodCategoryMap { FoodCategoryId = fCDrinks.Id, RestaurantId = resSandExpress.Id }
            };
            modelBuilder.Entity<RestaurantFoodCategoryMap>().HasData(restaurantFoodCategoryMapList);

            var foodList = new List<Food>
            {
                new Food { Id = Guid.NewGuid(), FoodCategoryId = fCPizza.Id, Name = "Farm House Pizza", UnitPrice = 100.00m },
                new Food { Id = Guid.NewGuid(), FoodCategoryId = fCPizza.Id, Name = "Deluxe Veggie Pizza", UnitPrice = 120.00m },
                new Food { Id = Guid.NewGuid(), FoodCategoryId = fCPizza.Id, Name = "Green Wave Pizza", UnitPrice = 150.00m },

                new Food { Id = Guid.NewGuid(), FoodCategoryId = fCSandwiches.Id, Name = "Cheese Grill Sandwich", UnitPrice = 70.00m },
                new Food { Id = Guid.NewGuid(), FoodCategoryId = fCSandwiches.Id, Name = "Veg Pan Sandwich", UnitPrice = 80.00m },

                new Food { Id = Guid.NewGuid(), FoodCategoryId = fCDrinks.Id, Name = "Coke", UnitPrice = 20.00m },
                new Food { Id = Guid.NewGuid(), FoodCategoryId = fCDrinks.Id, Name = "Maaza", UnitPrice = 20.00m }
            };
            modelBuilder.Entity<Food>().HasData(foodList);

            var fCmzPizzaBase = new FoodCustomization { Id = Guid.NewGuid(), Name = "Pizza Base", CanSelectMultipleOptions = false };
            var fCmzBread = new FoodCustomization { Id = Guid.NewGuid(), Name = "Bread", CanSelectMultipleOptions = false };
            var fCmzToppings = new FoodCustomization { Id = Guid.NewGuid(), Name = "Toppings", CanSelectMultipleOptions = true };
            var fCmzCheeseOptions = new FoodCustomization { Id = Guid.NewGuid(), Name = "Cheese Options", CanSelectMultipleOptions = true };
            var fCmzSauces = new FoodCustomization { Id = Guid.NewGuid(), Name = "Sauces", CanSelectMultipleOptions = true };
            modelBuilder.Entity<FoodCustomization>().HasData(fCmzPizzaBase, fCmzBread, fCmzToppings, fCmzCheeseOptions, fCmzSauces);

            var foodCategoryCustomizationMapList = new List<FoodCategoryCustomizationMap>
            {
                new FoodCategoryCustomizationMap{FoodCategoryId = fCPizza.Id, FoodCustomizationId = fCmzPizzaBase.Id},
                new FoodCategoryCustomizationMap{FoodCategoryId = fCPizza.Id, FoodCustomizationId = fCmzToppings.Id},
                new FoodCategoryCustomizationMap{FoodCategoryId = fCPizza.Id, FoodCustomizationId = fCmzCheeseOptions.Id},
                new FoodCategoryCustomizationMap{FoodCategoryId = fCPizza.Id, FoodCustomizationId = fCmzSauces.Id},

                new FoodCategoryCustomizationMap{FoodCategoryId = fCSandwiches.Id, FoodCustomizationId = fCmzBread.Id},
                new FoodCategoryCustomizationMap{FoodCategoryId = fCSandwiches.Id, FoodCustomizationId = fCmzToppings.Id},
                new FoodCategoryCustomizationMap{FoodCategoryId = fCSandwiches.Id, FoodCustomizationId = fCmzCheeseOptions.Id},
                new FoodCategoryCustomizationMap{FoodCategoryId = fCSandwiches.Id, FoodCustomizationId = fCmzSauces.Id}
            };
            modelBuilder.Entity<FoodCategoryCustomizationMap>().HasData(foodCategoryCustomizationMapList);

            var fCmzOptions = new List<FoodCustomizationOption> {
                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzPizzaBase.Id, Name = "Hand Tossed", UnitPrice = 50 },
                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzPizzaBase.Id, Name = "Fresh Pan", UnitPrice = 50 },
                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzPizzaBase.Id, Name = "Thin Crust", UnitPrice = 50 },

                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzToppings.Id, Name = "Black Olive", UnitPrice = 20 },
                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzToppings.Id, Name = "Red Paprika", UnitPrice = 20 },
                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzToppings.Id, Name = "Golden Corn", UnitPrice = 20 },
                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzToppings.Id, Name = "Panner", UnitPrice = 20 },

                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzCheeseOptions.Id, Name = "Mozzarella", UnitPrice = 10 },
                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzCheeseOptions.Id, Name = "Cheddar", UnitPrice = 10 },

                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzSauces.Id, Name = "Barbeque", UnitPrice = 10 },
                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzSauces.Id, Name = "Honey Mustard", UnitPrice = 10 },
                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzSauces.Id, Name = "Southwest", UnitPrice = 10 },

                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzBread.Id, Name = "Multi grain", UnitPrice = 10 },
                new FoodCustomizationOption { Id = Guid.NewGuid(), FoodCustomizationId = fCmzBread.Id, Name = "Oat", UnitPrice = 10 },
            };
            modelBuilder.Entity<FoodCustomizationOption>().HasData(fCmzOptions);
        }
    }
}
