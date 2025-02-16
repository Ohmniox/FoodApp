﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.API.Controllers.Shared;
using FoodApp.API.Filters;
using FoodApp.Core.Services.Contracts;
using FoodApp.Library.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [FoodApAuthorize((int)UserType.Consumer)]
    public class RestaurantController : FoodAppBaseController
    {
        private readonly IRestaurantService restaurantService;
        private readonly ILogger<RestaurantController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantController"/> class.
        /// </summary>
        /// <param name="restaurantService">The restaurant service.</param>
        /// <param name="logger">The logger.</param>
        public RestaurantController(IRestaurantService restaurantService, ILogger<RestaurantController> logger)
        {
            this.restaurantService = restaurantService;
            this.logger = logger;
        }

        /// <summary>
        /// Gets the restaurants.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetRestaurants()
        {
            logger.LogInformation("GetRestaurants request started");
            var restaurants = await restaurantService.GetRestaurantsAsync();
            logger.LogInformation("GetRestaurants request completed successfully");
            return this.Ok(restaurants);
        }

    }
}