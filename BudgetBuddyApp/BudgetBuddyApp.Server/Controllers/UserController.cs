using Microsoft.AspNetCore.Mvc;

namespace BudgetBuddyApp.Server.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
