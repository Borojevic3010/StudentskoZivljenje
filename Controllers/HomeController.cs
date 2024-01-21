using Microsoft.AspNetCore.Mvc;
using StudentskoZivljenje.Models;
using System.Diagnostics;

namespace StudentskoZivljenje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            return RedirectToAction("Dom");
        }

        public IActionResult Dom()
        {
            return View();
        }

        public IActionResult Hobi()
        {
            return View();
        }

        public IActionResult Registracija()
        {
            return View();  
        }

        public IActionResult Stipendija()
        {
            return View();
        }

        public IActionResult VpisTecaj()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
