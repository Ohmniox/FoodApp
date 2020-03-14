using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class FoodCustomizationOption
    {
        public Guid Id { get; set; }
        public Guid FoodCustomizationId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual FoodCustomization FoodCustomization { get; set; }
    }
}
