using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class Order : Entity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid RestaurantId { get; set; }
        public decimal TotalAmount { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }
}
