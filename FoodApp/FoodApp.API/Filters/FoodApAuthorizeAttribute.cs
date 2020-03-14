using FoodApp.Library.Constants;
using FoodApp.Library.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.API.Filters
{
    public class FoodApAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private readonly int allowedUserType;

        public FoodApAuthorizeAttribute(int allowedUserType)
        {
            this.allowedUserType = allowedUserType;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            System.Security.Claims.Claim userTypeClaim = context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == UserClaims.UserType);


            if (userTypeClaim == null)
            {
                context.Result = new UnauthorizedResult();
            }

            if (!int.TryParse(userTypeClaim.Value, out int userType))
            {
                context.Result = new UnauthorizedResult();
            }

            if (userType == (int)UserType.Consumer)
            {
                if (allowedUserType == (int)UserType.Admin)
                {
                    context.Result = new UnauthorizedResult();
                }
            }
        }
    }
}

