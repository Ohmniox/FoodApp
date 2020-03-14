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
    public class RestaurantController : FoodAppBaseController
    {
        private readonly IRestaurantService restaurantService;
        private readonly ILogger<RestaurantController> logger;

        public RestaurantController(IRestaurantService restaurantService, ILogger<RestaurantController> logger)
        {
            this.restaurantService = restaurantService;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetRestaurants()
        {
            var restaurants = await restaurantService.GetRestaurantsAsync();
            return this.Ok(restaurants);
        }

    }
}