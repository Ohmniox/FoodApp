using FoodApp.Core.Services.Contracts;
using FoodApp.Data;
using FoodApp.Domain.Mapper;
using FoodApp.Entities;
using FoodApp.Library.Enum;
using FoodApp.Library.Security;
using FoodApp.Models.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly FoodAppDbContext foodAppDbContext;
        private readonly ILogger<UserService> logger;

        public UserService(FoodAppDbContext foodAppDbContext, ILogger<UserService> logger)
        {
            this.foodAppDbContext = foodAppDbContext;
            this.logger = logger;
        }

        public Task<User> GetUser(string email)
        {
            return foodAppDbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task CreateConsumerUser(UserRequestModel userRequestModel)
        {
            var user = UserMapper.Map(userRequestModel);
            user.Id = Guid.NewGuid();
            user.PasswordHash = Helper.HashPassword(userRequestModel.Password);
            user.UserType = (int)UserType.Consumer;
            await foodAppDbContext.AddAsync(user);
            await foodAppDbContext.SaveChangesAsync();
        }
    }
}
