using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.API.Controllers.Shared;
using FoodApp.Core.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : FoodAppBaseController
    {
        private readonly IFoodService foodService;
        private readonly ILogger<FoodController> logger;

        public FoodController(IFoodService foodService, ILogger<FoodController> logger)
        {
            this.foodService = foodService;
            this.logger = logger;
        }

        [HttpGet("food-categories")]
        public async Task<IActionResult> GetFoodCategoriesForRestaurant([FromQuery]Guid restaurantId)
        {
            var foodCategoryList = await foodService.GetFoodCategoriesForRestaurantAsync(restaurantId);
            return this.Ok(foodCategoryList);
        }


        [HttpGet]
        public async Task<IActionResult> GetFoodByFoodCategory([FromQuery]Guid foodCategoryId)
        {
            var foods = await foodService.GetFoodsByFoodCategoryIdAsync(foodCategoryId);
            return this.Ok(foods);
        }
    }
}