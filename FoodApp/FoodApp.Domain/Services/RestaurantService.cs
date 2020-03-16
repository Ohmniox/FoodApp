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
    public class RestaurantService : IRestaurantService
    {
        private readonly FoodAppDbContext foodAppDbContext;
        private readonly ILogger<RestaurantService> logger;

        public RestaurantService(FoodAppDbContext foodAppDbContext, ILogger<RestaurantService> logger)
        {
            this.foodAppDbContext = foodAppDbContext;
            this.logger = logger;
        }

        public Task<List<Restaurant>> GetRestaurantsAsync()
        {
            return foodAppDbContext.Restaurants.AsNoTracking().ToListAsync();
        }
        public Task<Restaurant> GetRestaurantAsync(Guid restaurantId)
        {
            return foodAppDbContext.Restaurants.AsNoTracking().FirstOrDefaultAsync(x => x.Id == restaurantId);
        }
    }
}
