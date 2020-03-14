using FoodApp.Entities;
using FoodApp.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Domain.Mapper
{
    public static class UserMapper
    {
        public static User Map(UserRequestModel foodRequestModel)
        {
            return new User()
            {
                FirstName = foodRequestModel.FirstName,
                LastName = foodRequestModel.LastName,
                Email = foodRequestModel.Email
            };
        }
    }
}
