using FoodApp.API.Controllers;
using FoodApp.Core.Services.Contracts;
using FoodApp.Data;
using FoodApp.Domain.Services;
using FoodApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using Xunit;

namespace FoodApp.API.Test
{
    public class RestaurantAPIUnitTest
    {
        private IServiceProvider BuildServices(string databaseName)
        {
            var services = new ServiceCollection();
            services.AddDbContext<FoodAppDbContext>(item => item.UseInMemoryDatabase(databaseName));
            services.AddLogging();
            services.AddScoped<IRestaurantService, RestaurantService>();
            return services.BuildServiceProvider();
        }

        [Fact]
        public async void GetRestaurants_API_Should_Return_All_Restaurants()
        {
            //Arrange
            var services = BuildServices("GetRestaurants_API_Should_Return_All_Restaurants");
            var context = services.GetRequiredService<FoodAppDbContext>();
            var inputRestaurants = new List<Restaurant>
            {
                new Restaurant { Id = Guid.NewGuid(), Name = "Res 1" },
                new Restaurant { Id = Guid.NewGuid(), Name = "Res 2" },
                new Restaurant { Id = Guid.NewGuid(), Name = "Res 3" }
            };
            context.Restaurants.AddRange(inputRestaurants);
            context.SaveChanges();

            var restaurantService = services.GetRequiredService<IRestaurantService>();
            var controller = new RestaurantController(restaurantService, new Mock<ILogger<RestaurantController>>().Object);

            //Act
            var result = await controller.GetRestaurants();
            
            // Assert
            var okResult = result as OkObjectResult;
            var outputRestaurants = okResult.Value as List<Restaurant>;
            Assert.NotNull(okResult);
            Assert.Equal((int)HttpStatusCode.OK, okResult.StatusCode);
            Assert.Equal(inputRestaurants.Count, outputRestaurants.Count);
        }
    }
}
