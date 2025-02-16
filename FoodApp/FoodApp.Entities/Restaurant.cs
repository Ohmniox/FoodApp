﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class Restaurant : Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<RestaurantFoodCategoryMap> RestaurantFoodCategoryMaps { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
