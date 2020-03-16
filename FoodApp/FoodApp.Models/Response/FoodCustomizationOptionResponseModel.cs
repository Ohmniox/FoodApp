using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Models.Response
{
    public class FoodCustomizationOptionResponseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
