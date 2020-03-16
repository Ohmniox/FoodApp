using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodApp.Models.Request
{
    public class OrderRequestModel
    {
        public Guid RestaurantId { get; set; }
        public List<OrderLineRequestModel> OrderLines { get; set; }
        public class OrderLineRequestModel
        {
            public Guid FoodId { get; set; }
            public int Quantity { get; set; }
            public List<OrderLineOptionRequestModel> OrderLineOptions { get; set; }
            public class OrderLineOptionRequestModel
            {
                public Guid FoodCustomizationOptionId { get; set; }
            }
        }
    }
}
