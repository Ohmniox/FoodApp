using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class FoodCustomization : Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool CanSelectMultipleOptions { get; set; }
        public virtual List<FoodCustomizationOption> FoodCustomizationOptions { get; set; }
        public virtual List<FoodCategoryCustomizationMap> FoodCategoryCustomizationMaps { get; set; }
    }
}
