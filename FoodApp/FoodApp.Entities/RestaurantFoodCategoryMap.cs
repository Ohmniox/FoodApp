using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class RestaurantFoodCategoryMap
    {
        public Guid RestaurantId { get; set; }
        public Guid FoodCategoryId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
    }
}
