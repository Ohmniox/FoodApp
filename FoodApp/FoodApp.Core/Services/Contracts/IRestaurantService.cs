using FoodApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Services.Contracts
{
    public interface IRestaurantService : IService
    {
        public Task<List<Restaurant>> GetRestaurantsAsync();
    }
}
