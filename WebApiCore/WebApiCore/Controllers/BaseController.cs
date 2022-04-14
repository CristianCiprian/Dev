using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApiCore.Controllers {

    [Route("api")]
    public abstract class BaseController : ControllerBase
    {

        protected readonly IAuthenticationService authenticationService;

        public BaseController(IAuthenticationService authenticationService)
        {

            this.authenticationService = authenticationService;

        }

        protected const int STATUS_CODE_SUCCESS = StatusCodes.Status200OK;

        protected const int STATUS_CODE_VALIDATION_ERROR = StatusCodes.Status400BadRequest;

        protected const int STATUS_CODE_NOT_FOUND = StatusCodes.Status404NotFound;

        protected const int STATUS_CODE_UNEXPECTED = StatusCodes.Status500InternalServerError;

        protected const int STATUS_CODE_UNAUTHORIZED = StatusCodes.Status401Unauthorized;



        protected const string DEFAULT_NOT_FOUND_MESSAGE = "Not found :(";

        protected const string DEFAULT_UNAUTHORIZED_MESSAGE = "Unauthorized :(";    

          

        protected IActionResult CreateSuccessResponse(object data)
        {

            return new ObjectResult(data) { StatusCode = STATUS_CODE_SUCCESS };

        }

        protected IActionResult CreateUnexpectedErrorResponse(Exception ex)
        {

            return new ObjectResult("A intervenit o eroare...") { StatusCode = StatusCodes.Status400BadRequest };

        }

        protected IActionResult CreateUnauthorizedErrorResponse()
        {

            return new ObjectResult(DEFAULT_UNAUTHORIZED_MESSAGE) { StatusCode = STATUS_CODE_UNAUTHORIZED };

        }

        protected IActionResult CreateNotFoundErrorResponse(string message = null)
        {

            return new ObjectResult(message ?? DEFAULT_NOT_FOUND_MESSAGE) { StatusCode = STATUS_CODE_NOT_FOUND };

        }

    }

}