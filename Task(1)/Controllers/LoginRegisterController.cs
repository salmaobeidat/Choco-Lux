using Microsoft.AspNetCore.Mvc;

namespace Task_1_.Controllers
{
    public class LoginRegisterController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
