using Microsoft.AspNetCore.Mvc;
using todoonboard_api.InfoModels;
using todoonboard_api.Services;
using todoonboard_api.Models;

namespace todoonboard_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create")]

        public IActionResult create(UserRequest userRequest)
        {
            var user = _userService.create(userRequest);
            if(user == null) return BadRequest(user);
            return Ok(user);
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}