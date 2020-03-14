using FoodApp.Entities;
using FoodApp.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Services.Contracts
{
    public interface IUserService : IService
    {
        public Task CreateConsumerUser(UserRequestModel userRequestModel);
        public Task<User> GetUser(string email);
    }
}
