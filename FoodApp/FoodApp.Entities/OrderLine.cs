using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class OrderLine : Entity
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid FoodId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Order Order { get; set; }
        public virtual List<OrderLineOption> OrderLineOptions { get; set; }
    }
}
