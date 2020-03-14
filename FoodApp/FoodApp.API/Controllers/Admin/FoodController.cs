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

        public FoodController(IFoodService foodService, ILogger<FoodController> logger)
        {
            this.foodService = foodService;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetFoods()
        {
            var foods = await this.foodService.GetFoodsAsync();
            return this.Ok(foods);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFood([FromRoute(Name = "id")]Guid foodId)
        {
            var food = await this.foodService.GetFoodAsync(foodId);
            if (food == null)
            {
                return this.NotFound();
            }
            return this.Ok(food);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFood([FromBody]FoodRequestModel foodRequestModel)
        {
            var foodCategory = await this.foodService.GetFoodCategory(foodRequestModel.FoodCategoryId);
            if (foodCategory == null)
            {
                return this.BadRequest(new BadRequestResponseModel { ErrorMessage = "Invalid foodCategoryId" });
            }
            var foodId = await this.foodService.CreateFoodAsync(foodRequestModel);
            return CreatedAtAction("GetFood", new { id = foodId }, new { id = foodId });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFood([FromRoute(Name = "id")]Guid foodId, [FromBody] FoodRequestModel foodRequestModel)
        {
            var food = await this.foodService.GetFoodAsync(foodId);
            if (food == null)
            {
                return this.BadRequest(new BadRequestResponseModel { ErrorMessage = "Invalid foodId" });
            }

            var foodCategory = await this.foodService.GetFoodCategory(foodRequestModel.FoodCategoryId);
            if (foodCategory == null)
            {
                return this.BadRequest(new BadRequestResponseModel { ErrorMessage = "Invalid foodCategoryId" });
            }
            await this.foodService.UpdateFood(foodId, foodRequestModel);
            return this.NoContent();
        }
    }
}