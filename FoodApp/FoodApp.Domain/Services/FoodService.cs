using FoodApp.Core.Services.Contracts;
using FoodApp.Data;
using FoodApp.Entities;
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
            var foodCategoryIds = await foodAppDbContext.RestaurantFoodCategoryMaps.Where(x => x.RestaurantId == restaurantId)?.Select(x=>x.FoodCategoryId).ToListAsync();
            var foodCategoryList = await foodAppDbContext.FoodCategories.Where(x => foodCategoryIds.Any(f => f == x.Id)).ToListAsync();
            return foodCategoryList;
        }
    }
}
