using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using FoodApp.API.Controllers.Shared;
using FoodApp.Core.Services.Contracts;
using FoodApp.Library.Constants;
using FoodApp.Library.Security;
using FoodApp.Models.Config;
using FoodApp.Models.Request;
using FoodApp.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace FoodApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : FoodAppBaseController
    {
        private readonly IUserService userService;
        private readonly ConfigSettings settings;

        public AuthController(IUserService userService, ConfigSettings settings)
        {
            this.userService = userService;
            this.settings = settings;
        }

        [HttpPost("acquire-token")]
        public async Task<IActionResult> AcquireToken([FromBody] AcquireTokenRequestModel acquireTokenRequestModel)
        {
            var user = await userService.GetUser(acquireTokenRequestModel.Email);
            if (user == null)
            {
                return BadRequest(new BadRequestResponseModel { ErrorMessage = "Email or Password invalid" });
            }
            var checkPassword = Helper.VerifyPassword(acquireTokenRequestModel.Password, user.PasswordHash);
            if (!checkPassword)
            {
                return BadRequest(new BadRequestResponseModel { ErrorMessage = "Email or Password invalid" });
            }
            var authToken = GenerateAuthenticationToken(user.Email, user.Id, user.UserType);

            return this.Ok(new AcquireTokenResponseModel { Token = authToken });
        }

        private string GenerateAuthenticationToken(string email, Guid userID, int userType)
        {
            var signingKeyByteArray = Encoding.Default.GetBytes(settings.SigningKey);
            var securityKey = new SymmetricSecurityKey(signingKeyByteArray);
            var creds = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var handler = new JwtSecurityTokenHandler();
            var identity = new ClaimsIdentity(new GenericIdentity(email, "token"), new[] { new Claim(UserClaims.ID, userID.ToString()), new Claim(UserClaims.UserType, userType.ToString()) });
            var expiresOn = DateTime.Now.AddHours(int.Parse(settings.AuthTokenExpiryInHours));

            var token = handler.CreateToken(new SecurityTokenDescriptor
            {
                Audience = "FoodAppAPI",
                Issuer = "self",
                IssuedAt = DateTime.Now,
                SigningCredentials = creds,
                Subject = identity,
                Expires = expiresOn,
                NotBefore = DateTime.Now
            });
            return handler.WriteToken(token);
        }
    }
}