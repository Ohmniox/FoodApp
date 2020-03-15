using FoodApp.Data.Configurations;
using FoodApp.Entities;
using FoodApp.Library.Enum;
using FoodApp.Library.Security;
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

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<FoodCategoryCustomizationMap> FoodCategoryCustomizationMaps { get; set; }
        public virtual DbSet<FoodCustomization> FoodCustomizations { get; set; }
        public virtual DbSet<FoodCustomizationOption> FoodCustomizationOptions { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<RestaurantFoodCategoryMap> RestaurantFoodCategoryMaps { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }
        public virtual DbSet<OrderLineOption> OrderLineOptions { get; set; }



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
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderLineConfiguration());
            modelBuilder.ApplyConfiguration(new OrderLineOptionConfiguration());
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var resMcD = new Restaurant { Id = new Guid("{3FE35DD2-BEB3-4E5D-94DE-2252C1FFCB9E}"), Name = "McD" };
            var resPizzaHut = new Restaurant { Id = new Guid("{B94F227B-1865-4850-8556-876A03BB6A92}"), Name = "Pizza Hut" };
            var resSandExpress = new Restaurant { Id = new Guid("{19298EBD-7AB5-4010-9EF3-FBA93A575FB7}"), Name = "Sandwich Express" };
            modelBuilder.Entity<Restaurant>().HasData(resMcD, resPizzaHut, resSandExpress);

            var fCPizza = new FoodCategory { Id = new Guid("{24605DBF-FDA0-4001-9CD9-ED29F24B4F3A}"), Name = "Pizza" };
            var fCSandwiches = new FoodCategory { Id = new Guid("{8FBE84F8-F746-45E9-B679-75F8D7971D6F}"), Name = "Sandwiches" };
            var fCDrinks = new FoodCategory { Id = new Guid("{37706F0A-5309-4820-8529-33E98590F532}"), Name = "Drinks" };
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
                new Food { Id = new Guid("{6812E44B-136E-4C90-8C8F-19A8755227B9}"), FoodCategoryId = fCPizza.Id, Name = "Farm House Pizza", UnitPrice = 100.00m },
                new Food { Id = new Guid("{95BB4D6C-6642-4874-A4FB-9C89C0FAD96F}"), FoodCategoryId = fCPizza.Id, Name = "Deluxe Veggie Pizza", UnitPrice = 120.00m },
                new Food { Id = new Guid("{3479CE8F-AD14-43F1-89E2-305E0EC9D7D1}"), FoodCategoryId = fCPizza.Id, Name = "Green Wave Pizza", UnitPrice = 150.00m },

                new Food { Id = new Guid("{AE2ADADB-C7C9-431B-BEBE-0FB5696AEC5C}"), FoodCategoryId = fCSandwiches.Id, Name = "Cheese Grill Sandwich", UnitPrice = 70.00m },
                new Food { Id = new Guid("{01DE8EFA-B104-4F4C-A06E-1AEAC87A058D}"), FoodCategoryId = fCSandwiches.Id, Name = "Veg Pan Sandwich", UnitPrice = 80.00m },

                new Food { Id = new Guid("{F8B743B5-4AC4-4FD9-8D61-9D3F230752BB}"), FoodCategoryId = fCDrinks.Id, Name = "Coke", UnitPrice = 20.00m },
                new Food { Id = new Guid("{13AD8C09-3A52-439B-B5CF-7E45CB73A93D}"), FoodCategoryId = fCDrinks.Id, Name = "Maaza", UnitPrice = 20.00m }
            };
            modelBuilder.Entity<Food>().HasData(foodList);

            var fCmzPizzaBase = new FoodCustomization { Id = new Guid("{6752518F-A587-4EFD-9956-C2DC0A3341D0}"), Name = "Pizza Base", CanSelectMultipleOptions = false };
            var fCmzBread = new FoodCustomization { Id = new Guid("{2D6D5A19-CB3D-4B7A-A8CB-9A51B85DB94A}"), Name = "Bread", CanSelectMultipleOptions = false };
            var fCmzToppings = new FoodCustomization { Id = new Guid("{9917EC41-5ADE-4A64-AF24-AD034CC4F983}"), Name = "Toppings", CanSelectMultipleOptions = true };
            var fCmzCheeseOptions = new FoodCustomization { Id = new Guid("{8069E3C0-0642-4633-BC15-6928E54B16B0}"), Name = "Cheese Options", CanSelectMultipleOptions = true };
            var fCmzSauces = new FoodCustomization { Id = new Guid("{515DA683-6CAF-473F-9F17-17AA50021D82}"), Name = "Sauces", CanSelectMultipleOptions = true };
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
                new FoodCustomizationOption { Id = new Guid("{CED57ABC-D59A-4A55-9395-213AC61ACF49}"), FoodCustomizationId = fCmzPizzaBase.Id, Name = "Hand Tossed", UnitPrice = 50 },
                new FoodCustomizationOption { Id = new Guid("{254E6270-854C-4976-8F3E-F91EFC35189D}"), FoodCustomizationId = fCmzPizzaBase.Id, Name = "Fresh Pan", UnitPrice = 50 },
                new FoodCustomizationOption { Id = new Guid("{E81FDD73-78E8-4836-8030-6B57B440360A}"), FoodCustomizationId = fCmzPizzaBase.Id, Name = "Thin Crust", UnitPrice = 50 },

                new FoodCustomizationOption { Id = new Guid("{590C3ECE-DAA1-406A-A324-B2571D47EDFA}"), FoodCustomizationId = fCmzToppings.Id, Name = "Black Olive", UnitPrice = 20 },
                new FoodCustomizationOption { Id = new Guid("{C3A0FADD-3A2D-4244-8BC9-166F837BC943}"), FoodCustomizationId = fCmzToppings.Id, Name = "Red Paprika", UnitPrice = 20 },
                new FoodCustomizationOption { Id = new Guid("{EFF92807-35C0-4D4E-A677-B11BAE3ACB38}"), FoodCustomizationId = fCmzToppings.Id, Name = "Golden Corn", UnitPrice = 20 },
                new FoodCustomizationOption { Id = new Guid("{B090EE10-6214-46FB-B6B4-AE0425200AF5}"), FoodCustomizationId = fCmzToppings.Id, Name = "Panner", UnitPrice = 20 },

                new FoodCustomizationOption { Id = new Guid("{D92B9ADD-A74B-4959-8ACD-3833863838EC}"), FoodCustomizationId = fCmzCheeseOptions.Id, Name = "Mozzarella", UnitPrice = 10 },
                new FoodCustomizationOption { Id = new Guid("{E743E020-9B3C-4E3B-961E-C99EDE8967FB}"), FoodCustomizationId = fCmzCheeseOptions.Id, Name = "Cheddar", UnitPrice = 10 },

                new FoodCustomizationOption { Id = new Guid("{7C202C73-CDF7-4C96-88ED-03F7A66DE8F3}"), FoodCustomizationId = fCmzSauces.Id, Name = "Barbeque", UnitPrice = 10 },
                new FoodCustomizationOption { Id = new Guid("{407D019D-2B50-4D3D-AFF2-37D19D5C13F3}"), FoodCustomizationId = fCmzSauces.Id, Name = "Honey Mustard", UnitPrice = 10 },
                new FoodCustomizationOption { Id = new Guid("{391F0017-9C03-4A04-9640-D2ADCC485995}"), FoodCustomizationId = fCmzSauces.Id, Name = "Southwest", UnitPrice = 10 },

                new FoodCustomizationOption { Id = new Guid("{65754491-842F-4116-9461-5B945A07AC5C}"), FoodCustomizationId = fCmzBread.Id, Name = "Multi grain", UnitPrice = 10 },
                new FoodCustomizationOption { Id = new Guid("{763D6AE6-6BB6-43FB-B7EF-A16B3BA6BF29}"), FoodCustomizationId = fCmzBread.Id, Name = "Oat", UnitPrice = 10 },
            };
            modelBuilder.Entity<FoodCustomizationOption>().HasData(fCmzOptions);
            
            //Password = "123"
            var user = new User { Id = new Guid("{6CBCA69D-E9A1-4896-A1B3-35205F86A3B0}"), Email = "admin@foodapp.com", PasswordHash = "$2a$11$gkBFRKDn7v8xUicttBIfkOZ/NinK7NdB9Zl.Xd0bfh9laaXO4bhP6", FirstName = "Admin", LastName = "Admin", UserType = (int)UserType.Admin };
            modelBuilder.Entity<User>().HasData(user);
        }
    }
}
