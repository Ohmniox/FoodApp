using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Models.Config
{
    public class ConfigSettings
    {
        public string SigningKey { get; set; }
        public string AuthTokenExpiryInHours { get; set; }
    }
}
