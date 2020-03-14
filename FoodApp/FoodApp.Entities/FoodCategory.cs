using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class FoodCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<RestaurantFoodCategoryMap> RestaurantFoodCategoryMaps { get; set; }
        public virtual List<Food> Foods { get; set; }
        public virtual List<FoodCategoryCustomizationMap> FoodCategoryCustomizationMaps { get; set; }
    }
}
