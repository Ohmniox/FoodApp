using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Models.Response
{
    public class FoodResponseModel
    {
        public Guid Id { get; set; }
        public Guid FoodCategoryId { get; set; }
        public string FoodCategoryName { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
