using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Models.Request
{
    public class RequestInfoModel
    {
        public Guid UserId { get; set; }
        public int UserType { get; set; }
    }
}
