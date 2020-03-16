using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodApp.Models.Request
{
    public class OrderResponseModel
    {
        public Guid OrderId { get; set; }
        public Guid RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
