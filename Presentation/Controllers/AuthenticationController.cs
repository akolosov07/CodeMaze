﻿using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Presentation.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AuthenticationController(IServiceManager service) => _service = service;


        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            var result = await _service.AuthenticationService.RegisterUser(userForRegistration);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors) 
                { 
                    ModelState.TryAddModelError(error.Code, error.Description); 
                }
                return BadRequest(ModelState);
            }

            return StatusCode(201);
        }
    }
}
