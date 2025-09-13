using BudgetBuddyApp.Server.Entities;
using BudgetBuddyApp.Server.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBuddyApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService) {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserEntity>>> GetUsers()
        {
            try
            {
                var users = await _userService.GetUsersAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
