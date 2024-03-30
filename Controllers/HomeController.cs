
using LearnWeb.Data;
using LearnWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LearnWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            using (var dbContext = new TestContext())
            {
                var items = dbContext.Items.ToList();
                return View(items);
            }
        }
        public IActionResult Login()
        {
            return Redirect("/Login");
		}
        public IActionResult Registor()
        {
            return Redirect("/Regítor");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
