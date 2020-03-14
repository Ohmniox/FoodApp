using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class Food
    {
        public Guid Id { get; set; }
        public Guid FoodCategoryId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
    }
}
