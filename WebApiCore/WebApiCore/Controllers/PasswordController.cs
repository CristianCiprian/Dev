using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiCore.Framework;

namespace WebApiCore.Controllers
{
    [ApiController]
    [Route("/API")]
    public class PasswordController : BaseController
    {
        private readonly IPasswordService passwordService;
        public PasswordController(IAuthenticationService authenticationService,IPasswordService passwordService) :base(authenticationService)
        {
                this.passwordService = passwordService;
        }

        [Route("Password/{userId}")]
        [HttpGet]
        public virtual async Task<IActionResult> GetPassword(int userId, DateTime dateTime)
        {
            try {
                if (string.IsNullOrEmpty(userId.ToString()) ) throw new ArgumentNullException();
               
                var result = await passwordService.GeneratePassword(userId, dateTime);
                return new ObjectResult(result);
            }         
            catch (Exception ex)
            {
                return CreateUnexpectedErrorResponse(ex);
            }

        }

        [Route("Check/{password}")]
        [HttpGet]
        public virtual async Task<IActionResult> CheckPassword(string password)
        {
            try
            {
                if (string.IsNullOrEmpty(password)) throw new ArgumentNullException();

                var result = await passwordService.CheckPassword(password);
                return new ObjectResult(result);
            }
            catch (Exception ex)
            {
                return CreateUnexpectedErrorResponse(ex);
            }

        }

        [Route("Welcome")]
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
