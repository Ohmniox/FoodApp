using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class OrderLineOption : Entity
    {
        public Guid Id { get; set; }
        public Guid OrderLineId { get; set; }
        public Guid FoodCustomizationOptionId { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual OrderLine OrderLine { get; set; }
    }
}
