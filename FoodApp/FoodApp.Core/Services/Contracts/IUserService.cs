using FoodApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Services.Contracts
{
    public interface IUserService : IService
    {
        public Task<User> GetUser(string email);
    }
}
