using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Entities
{
    public class User : Entity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int UserType { get; set; }
    }
}
