using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodApp.Models.Request
{
    public class OrderDetailResponseModel
    {
        public Guid OrderId { get; set; }
        public Guid RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderLineResponseModel> OrderLines { get; set; }
        public class OrderLineResponseModel
        {
            public Guid FoodId { get; set; }
            public string FoodName { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public List<OrderLineOptionResponseModel> OrderLineOptions { get; set; }
            public class OrderLineOptionResponseModel
            {
                public Guid FoodCustomizationOptionId { get; set; }
                public string FoodCustomizationOptionName { get; set; }
                public decimal UnitPrice { get; set; }
            }
        }
    }
}
