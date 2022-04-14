using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using PaswordGenerate.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiCore.Framework;

namespace WebApiCore.Controllers
{
    [ApiController]
    [Route("api/password")]
    public class PasswordController : BaseController
    {
        private readonly IPasswordService passwordService;
        public PasswordController(IAuthenticationService authenticationService,IPasswordService passwordService) :base(authenticationService)
        {
                this.passwordService = passwordService;
        }

        //[Route("Password/{userId}")]
        //[HttpGet]
        //public virtual async Task<IActionResult> GetPassword(int userId, DateTime dateTime)
        //{
        //    try {
        //        if (string.IsNullOrEmpty(userId.ToString()) ) throw new ArgumentNullException();
               
        //        var result = await passwordService.GeneratePassword(userId, dateTime);
        //        return new ObjectResult(result);
        //    }         
        //    catch (Exception ex)
        //    {
        //        return CreateUnexpectedErrorResponse(ex);
        //    }

        //}

        [Route("generate")]
        [HttpPost]
        [ProducesResponseType(statusCode: 200, type: typeof(User))]
        public virtual async Task<IActionResult> GeneratePassword([FromBody] User user)
        {
            try
            {
                if (user.UserId == 0) throw new ArgumentNullException();

                var result = await passwordService.GeneratePassword(user.UserId, user.DateTimeUser);
                return CreateSuccessResponse(result);
            }
            catch (Exception ex)
            {
                return CreateUnexpectedErrorResponse(ex);
            }

        }

        [Route("check/{password}")]
        [HttpGet]
        public virtual async Task<IActionResult> CheckPassword(string password)
        {
            try
            {
                if (string.IsNullOrEmpty(password)) throw new ArgumentNullException();

                var result = await passwordService.CheckPassword(password);
                return CreateSuccessResponse(result);
            }
            catch (Exception ex)
            {
                return CreateUnexpectedErrorResponse(ex);
            }

        }

        [Route("welcome")]
        [HttpGet]
        public virtual async Task<IActionResult> GetWelcome()
        {
            try
            {
                string message = "Welcome to Cristian Api!";
                return new ObjectResult(message);
            }
            catch (Exception ex)
            {
                return CreateUnexpectedErrorResponse(ex);

            }

        }
    }
}
