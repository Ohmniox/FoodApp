using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Models.Response
{
    public class FoodCustomizationResponseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool CanSelectMultipleOptions { get; set; }
        public List<FoodCustomizationOptionResponseModel> FoodCustomizationOptions { get; set; }
    }
}
