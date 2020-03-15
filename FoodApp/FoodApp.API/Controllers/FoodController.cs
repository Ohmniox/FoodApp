using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.API.Controllers.Shared;
using FoodApp.API.Filters;
using FoodApp.Core.Services.Contracts;
using FoodApp.Library.Enum;
using FoodApp.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [FoodApAuthorize((int)UserType.Consumer)]
    public class FoodController : FoodAppBaseController
    {
        private readonly IFoodService foodService;
        private readonly IRestaurantService restaurantService;
        private readonly ILogger<FoodController> logger;

        public FoodController(IFoodService foodService, IRestaurantService restaurantService, ILogger<FoodController> logger)
        {
            this.foodService = foodService;
            this.restaurantService = restaurantService;
            this.logger = logger;
        }

        [HttpGet("food-categories")]
        public async Task<IActionResult> GetFoodCategoriesForRestaurant([FromQuery]Guid restaurantId)
        {
            logger.LogInformation($"GetFoodCategoriesForRestaurant request started with restaurantId : {restaurantId}");
            var restaurant = await restaurantService.GetRestaurantAsync(restaurantId);
            if (restaurant == null)
            {
                logger.LogWarning($"Invalid restaurantId : {restaurantId}");
                return BadRequest(new BadRequestResponseModel { ErrorMessage = "Invalid restaurantId" });
            }

            var foodCategoryList = await foodService.GetFoodCategoriesForRestaurantAsync(restaurantId);
            logger.LogInformation("GetFoodCategoriesForRestaurant request completed successfully");
            return this.Ok(foodCategoryList);
        }


        [HttpGet]
        public async Task<IActionResult> GetFoodByFoodCategory([FromQuery]Guid foodCategoryId)
        {
            logger.LogInformation("GetFoodByFoodCategory request started");
            var foodCategory = await foodService.GetFoodCategoryAsync(foodCategoryId);
            if (foodCategory == null)
            {
                logger.LogWarning($"Invalid foodCategoryId : {foodCategoryId}");
                return BadRequest(new BadRequestResponseModel { ErrorMessage = "Invalid foodCategoryId" });
            }

            var foods = await foodService.GetFoodsByFoodCategoryIdAsync(foodCategoryId);
            logger.LogInformation("GetFoodByFoodCategory request completed successfully");
            return this.Ok(foods);
        }
    }
}