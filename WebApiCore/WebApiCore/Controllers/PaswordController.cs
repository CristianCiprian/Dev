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
    [Route("[controller]")]
    public class PaswordController : BaseController
    {
        private readonly IPaswordService paswordService;
        public PaswordController(IAuthenticationService authenticationService,IPaswordService paswordService) :base(authenticationService)
        {
                this.paswordService = paswordService;
        }

        [Route("Pasword/{userId}")]
        [HttpGet]
        public virtual async Task<IActionResult> GetPasword(int userId, DateTime dateTime)
        {
            try {
                if (string.IsNullOrEmpty(userId.ToString()) ) throw new ArgumentNullException();
               
                var result = await paswordService.GeneratePasword(userId, dateTime);
                return new ObjectResult(result);
            }         
            catch (Exception ex)
            {
                return CreateUnexpectedErrorResponse(ex);
                
            }

        }
    }
}
