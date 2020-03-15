using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.API.Controllers.Shared;
using FoodApp.API.Filters;
using FoodApp.Core.Services.Contracts;
using FoodApp.Library.Enum;
using FoodApp.Models.Request;
using FoodApp.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodApp.API.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [FoodApAuthorize((int)UserType.Admin)]
    public class FoodController : FoodAppBaseController
    {
        private readonly IFoodService foodService;
        private readonly ILogger<FoodController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="FoodController"/> class.
        /// </summary>
        /// <param name="foodService">The food service.</param>
        /// <param name="logger">The logger.</param>
        public FoodController(IFoodService foodService, ILogger<FoodController> logger)
        {
            this.foodService = foodService;
            this.logger = logger;
        }

        /// <summary>
        /// Gets the foods.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetFoods()
        {
            logger.LogInformation("GetFoods request started");
            var foods = await this.foodService.GetFoodsAsync();
            logger.LogInformation("GetFoods request completed successfully");
            return this.Ok(foods);
        }

        /// <summary>
        /// Gets the food by id.
        /// </summary>
        /// <param name="foodId">The food identifier.</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFood([FromRoute(Name = "id")]Guid foodId)
        {
            logger.LogInformation("GetFood request started");
            var food = await this.foodService.GetFoodAsync(foodId);
            if (food == null)
            {
                logger.LogWarning($"Food with id : {foodId} not found");
                return this.NotFound();
            }
            logger.LogInformation("GetFoodsrequest completed successfully");
            return this.Ok(food);
        }

        /// <summary>
        /// Creates the food.
        /// </summary>
        /// <param name="foodRequestModel">The food request model.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateFood([FromBody]FoodRequestModel foodRequestModel)
        {
            logger.LogInformation("CreateFood request started");
            var foodCategory = await this.foodService.GetFoodCategoryAsync(foodRequestModel.FoodCategoryId);
            if (foodCategory == null)
            {
                logger.LogWarning($"Invalid foodCateogoryId : {foodRequestModel.FoodCategoryId}");
                return this.BadRequest(new BadRequestResponseModel { ErrorMessage = "Invalid foodCategoryId" });
            }
            var foodId = await this.foodService.CreateFoodAsync(foodRequestModel);
            logger.LogInformation("CreateFood completed successfully");
            return CreatedAtAction("GetFood", new { id = foodId }, new { id = foodId });
        }

        /// <summary>
        /// Updates the food.
        /// </summary>
        /// <param name="foodId">The food identifier.</param>
        /// <param name="foodRequestModel">The food request model.</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFood([FromRoute(Name = "id")]Guid foodId, [FromBody] FoodRequestModel foodRequestModel)
        {
            logger.LogInformation("UpdateFood request started");
            var food = await this.foodService.GetFoodAsync(foodId);
            if (food == null)
            {
                logger.LogWarning($"Invalid foodId : {foodId}");
                return this.BadRequest(new BadRequestResponseModel { ErrorMessage = "Invalid foodId" });
            }

            var foodCategory = await this.foodService.GetFoodCategoryAsync(foodRequestModel.FoodCategoryId);
            if (foodCategory == null)
            {
                logger.LogWarning($"Invalid foodCateogoryId : {foodRequestModel.FoodCategoryId}");
                return this.BadRequest(new BadRequestResponseModel { ErrorMessage = "Invalid foodCategoryId" });
            }
            await this.foodService.UpdateFoodAsync(foodId, foodRequestModel);
            logger.LogInformation("UpdateFood completed successfully");
            return this.NoContent();
        }
    }
}