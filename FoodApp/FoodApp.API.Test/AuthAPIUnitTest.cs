using FoodApp.API.Controllers;
using FoodApp.Core.Services.Contracts;
using FoodApp.Data;
using FoodApp.Domain.Services;
using FoodApp.Entities;
using FoodApp.Library.Enum;
using FoodApp.Models.Request;
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
    public class AuthAPIUnitTest
    {
        private IServiceProvider BuildServices(string databaseName)
        {
            var services = new ServiceCollection();
            services.AddDbContext<FoodAppDbContext>(item => item.UseInMemoryDatabase(databaseName));
            services.AddLogging();
            services.AddScoped<IUserService, UserService>();
            return services.BuildServiceProvider();
        }

        [Fact]
        public async void SignUp_API_Should_Create_ConsumerType_User()
        {
            //Arrange
            var services = BuildServices("SignUp_API_Should_Create_ConsumerType_User");
            var context = services.GetRequiredService<FoodAppDbContext>();
            var userService = services.GetRequiredService<IUserService>();
            var controller = new AuthController(userService, new Models.Config.ConfigSettings { SigningKey = Guid.NewGuid().ToString(), AuthTokenExpiryInHours = "1" }, new Mock<ILogger<AuthController>>().Object);
            var userRequestModel = new UserRequestModel
            {
                Email = "test@foodapp.com",
                Password = "test123",
                FirstName = "Test",
                LastName = "User"
            };

            //Act
            var result = await controller.SignUp(userRequestModel);

            // Assert
            var okResult = result as AcceptedResult;
            var user = await context.Users.FirstOrDefaultAsync(x => x.Email == userRequestModel.Email);
            Assert.NotNull(user);
            Assert.Equal(user.UserType, (int)UserType.Consumer);
            Assert.Equal((int)HttpStatusCode.Accepted, okResult.StatusCode);
        }
    }
}
