using FoodApp.Entities;
using FoodApp.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Services.Contracts
{
    public interface IFoodService : IService
    {
        public Task<List<FoodCategory>> GetFoodCategoriesForRestaurantAsync(Guid restaurantId);
        public Task<List<FoodResponseModel>> GetFoodsByFoodCategoryIdAsync(Guid foodCategoryId);
    }
}
