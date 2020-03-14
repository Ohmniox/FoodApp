using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodApp.Models.Request
{
    public class UserRequestModel
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Password { get; set; }
    }
}
