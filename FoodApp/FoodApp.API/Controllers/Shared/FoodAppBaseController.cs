using FoodApp.Library.Constants;
using FoodApp.Models.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.API.Controllers.Shared
{
    public abstract class FoodAppBaseController : ControllerBase
    {
        private RequestInfoModel RequestInfoModelField;
        protected RequestInfoModel RequestInfoModel
        {
            get
            {
                if (this.RequestInfoModelField == null)
                {
                    var userId = this.User.Claims.FirstOrDefault(x => x.Type == UserClaims.ID);
                    var userType = this.User.Claims.FirstOrDefault(x => x.Type == UserClaims.UserType);
                    this.RequestInfoModelField = new RequestInfoModel
                    {
                        UserId = Guid.Parse(userId.Value),
                        UserType = int.Parse(userType.Value)
                    };
                }

                return this.RequestInfoModelField;
            }
        }
    }
}
