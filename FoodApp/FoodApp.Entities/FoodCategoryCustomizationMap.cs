using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class FoodCategoryCustomizationMap
    {
        public Guid FoodCategoryId { get; set; }
        public Guid FoodCustomizationId { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
        public virtual FoodCustomization FoodCustomization { get; set; }
    }
}
