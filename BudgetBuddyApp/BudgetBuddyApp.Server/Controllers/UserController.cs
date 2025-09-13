using BudgetBuddyApp.Server.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBuddyApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService) {
            _userService = userService;
        }

        public async 
    }
}
