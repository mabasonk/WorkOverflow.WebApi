using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkOverflow.WebApi.Application.User;
using WorkOverflow.WebApi.IServices.Interfaces.User;

namespace WorkOverflow.WebApi.Controllers.User
{
    [ApiController]
    [Route("user")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UserViewModel user)
        {
            try
            {
                return Ok(await _userService.Register(user));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginViewModel userLogin)
        {
            try
            {
                return Ok(await _userService.Login(userLogin));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateUser(UserViewModel user)
        {
            try
            {
                return Ok(await _userService.UpdateUser(user));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpPost]
        [Route("suspend")]
        public async Task<IActionResult> SuspendUser(string username)
        {
            try
            {
                return Ok(await _userService.SuspendUser(username));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
