using FoodApp.Entities;
using FoodApp.Models.Request;
using FoodApp.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Services.Contracts
{
    public interface IFoodService : IService
    {
        public Task<List<FoodResponseModel>> GetFoodsAsync();
        public Task<FoodResponseModel> GetFoodAsync(Guid foodId);
        public Task<Guid> CreateFoodAsync(FoodRequestModel foodRequestModel);
        public Task UpdateFoodAsync(Guid foodId, FoodRequestModel foodRequestModel);
        
        public Task<List<FoodCategory>> GetFoodCategoriesForRestaurantAsync(Guid restaurantId);
        public Task<List<FoodDetailResponseModel>> GetFoodsByFoodCategoryIdAsync(Guid foodCategoryId);

        public Task<FoodCategory> GetFoodCategoryAsync(Guid foodCategoryId);
    }
}
