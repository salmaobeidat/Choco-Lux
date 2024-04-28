using Microsoft.AspNetCore.Mvc;

namespace Task_1_.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
