using FoodApp.Core.Services.Contracts;
using FoodApp.Data;
using FoodApp.Entities;
using FoodApp.Models.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Domain.Services
{
    public class FoodService : IFoodService
    {
        private readonly FoodAppDbContext foodAppDbContext;
        private readonly ILogger<FoodService> logger;

        public FoodService(FoodAppDbContext foodAppDbContext, ILogger<FoodService> logger)
        {
            this.foodAppDbContext = foodAppDbContext;
            this.logger = logger;
        }

        public async Task<List<FoodCategory>> GetFoodCategoriesForRestaurantAsync(Guid restaurantId)
        {
            var foodCategoryIds = await foodAppDbContext.RestaurantFoodCategoryMaps.Where(x => x.RestaurantId == restaurantId)?.Select(x => x.FoodCategoryId).ToListAsync();
            var foodCategoryList = await foodAppDbContext.FoodCategories.Where(x => foodCategoryIds.Any(f => f == x.Id)).ToListAsync();
            return foodCategoryList;
        }

        public async Task<List<FoodResponseModel>> GetFoodsByFoodCategoryIdAsync(Guid foodCategoryId)
        {

            var foodCustomizationIds = await foodAppDbContext.FoodCategoryCustomizationMaps.Where(x => x.FoodCategoryId == foodCategoryId)?
                                            .Select(x => x.FoodCustomizationId)
                                            .ToListAsync();

            var foodCustomizationList = await foodAppDbContext.FoodCustomizations.Where(x => foodCustomizationIds.Any(f => f == x.Id))
                                            .Include(x => x.FoodCustomizationOptions)
                                            .Select(x => new FoodCustomizationResponseModel
                                            {
                                                Id = x.Id,
                                                Name = x.Name,
                                                CanSelectMultipleOptions = x.CanSelectMultipleOptions,
                                                FoodCustomizationOptions = x.FoodCustomizationOptions.Select(s => new FoodCustomizationOptionResponseModel
                                                {
                                                    Id = s.Id,
                                                    Name = s.Name,
                                                    UnitPrice = s.UnitPrice
                                                }).ToList()
                                            })
                                            .ToListAsync();

            var foods = await foodAppDbContext.Foods.Where(x => x.FoodCategoryId == foodCategoryId)
                                            .Select(x => new FoodResponseModel
                                            {
                                                Id = x.Id,
                                                Name = x.Name,
                                                UnitPrice = x.UnitPrice,
                                                FoodCategoryId = x.FoodCategoryId,
                                                FoodCustomizations = foodCustomizationList
                                            })
                                            .ToListAsync();
            return foods;
        }
    }
}
