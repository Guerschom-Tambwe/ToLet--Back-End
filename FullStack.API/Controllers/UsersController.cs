using Microsoft.AspNetCore.Mvc;
using FullStack.API.Services;
using FullStack.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using FluentValidation;
using FullStack.API.Helpers;

namespace FullStack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
            return BadRequest(new { message = "Email or password is incorrect" });

            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [AllowAnonymous]
        [HttpPost("newuser/register")]
        public ActionResult<RegisterModel> Register([FromBody] RegisterModel user)
        {

            try
            {
                // create user
                _userService.Create(user);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("unsecure")]
        public IActionResult GetAllUnsecure()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}
