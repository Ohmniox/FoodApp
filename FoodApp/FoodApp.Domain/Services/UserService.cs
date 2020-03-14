using FoodApp.Core.Services.Contracts;
using FoodApp.Data;
using FoodApp.Entities;
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
    }
}
