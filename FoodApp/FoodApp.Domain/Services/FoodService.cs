using FoodApp.Core.Services.Contracts;
using FoodApp.Data;
using FoodApp.Domain.Mapper;
using FoodApp.Entities;
using FoodApp.Models.Request;
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
            var foodCategoryIds = await foodAppDbContext.RestaurantFoodCategoryMaps.AsNoTracking().Where(x => x.RestaurantId == restaurantId)?.Select(x => x.FoodCategoryId).ToListAsync();
            var foodCategoryList = await foodAppDbContext.FoodCategories.AsNoTracking().Where(x => foodCategoryIds.Any(f => f == x.Id)).ToListAsync();
            return foodCategoryList;
        }

        public async Task<List<FoodDetailResponseModel>> GetFoodsByFoodCategoryIdAsync(Guid foodCategoryId)
        {

            var foodCustomizationIds = await foodAppDbContext.FoodCategoryCustomizationMaps.AsNoTracking().Where(x => x.FoodCategoryId == foodCategoryId)?
                                            .Select(x => x.FoodCustomizationId)
                                            .ToListAsync();

            var foodCustomizationList = await foodAppDbContext.FoodCustomizations.AsNoTracking().Where(x => foodCustomizationIds.Any(f => f == x.Id))
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

            var foods = await foodAppDbContext.Foods.AsNoTracking().Where(x => x.FoodCategoryId == foodCategoryId)
                                            .Select(x => new FoodDetailResponseModel
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

        public Task<List<FoodResponseModel>> GetFoodsAsync()
        {
            return foodAppDbContext.Foods.AsNoTracking()
                    .Include(x => x.FoodCategory)
                    .Select(x => new FoodResponseModel
                    {
                        Id = x.Id,
                        FoodCategoryId = x.FoodCategoryId,
                        FoodCategoryName = x.FoodCategory.Name,
                        Name = x.Name,
                        UnitPrice = x.UnitPrice
                    })
                    .ToListAsync();
        }

        public async Task<FoodResponseModel> GetFoodAsync(Guid foodId)
        {
            var food = await foodAppDbContext.Foods.AsNoTracking()
                        .Include(x => x.FoodCategory)
                        .FirstOrDefaultAsync(x => x.Id == foodId);
            var foodResponseModel = new FoodResponseModel
            {
                Id = food.Id,
                FoodCategoryId = food.FoodCategory.Id,
                FoodCategoryName = food.FoodCategory.Name,
                Name = food.Name,
                UnitPrice = food.UnitPrice
            };
            return foodResponseModel;
        }

        public async Task<Guid> CreateFoodAsync(FoodRequestModel foodRequestModel)
        {
            var food = FoodMapper.Map(foodRequestModel);
            food.Id = Guid.NewGuid();

            await foodAppDbContext.AddAsync(food);
            await foodAppDbContext.SaveChangesAsync();

            return food.Id;
        }

        public async Task UpdateFood(Guid foodId, FoodRequestModel foodRequestModel)
        {
            var food = await foodAppDbContext.Foods.FirstOrDefaultAsync(x => x.Id == foodId);
            FoodMapper.Map(foodRequestModel, food);
            foodAppDbContext.Update(food);
            await foodAppDbContext.SaveChangesAsync();
        }

        public Task<FoodCategory> GetFoodCategory(Guid foodCategoryId)
        {
            return foodAppDbContext.FoodCategories.AsNoTracking().FirstOrDefaultAsync(x => x.Id == foodCategoryId);
        }
    }
}
