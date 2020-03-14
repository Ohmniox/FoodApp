using FoodApp.Entities;
using FoodApp.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Domain.Mapper
{
    public static class FoodMapper
    {
        public static Food Map(FoodRequestModel foodRequestModel)
        {
            return new Food()
            {
                FoodCategoryId = foodRequestModel.FoodCategoryId,
                Name = foodRequestModel.Name,
                UnitPrice = foodRequestModel.UnitPrice
            };
        }

        public static void Map(FoodRequestModel srcFoodRequestModel, Food dstFood)
        {
            dstFood.FoodCategoryId = srcFoodRequestModel.FoodCategoryId;
            dstFood.Name = srcFoodRequestModel.Name;
            dstFood.UnitPrice = srcFoodRequestModel.UnitPrice;
        }
    }
}
