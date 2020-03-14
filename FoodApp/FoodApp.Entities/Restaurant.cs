using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class Restaurant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<RestaurantFoodCategoryMap> RestaurantFoodCategoryMaps { get; set; }
    }
}
