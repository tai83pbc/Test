using Microsoft.AspNetCore.Mvc;

namespace LearnWeb.Controllers
{
    public class RegistorController : Controller
    {
        public IActionResult Index()
        {
            return View("Registor");
        }
    }
}
