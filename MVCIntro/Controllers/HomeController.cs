using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string name = "Nisse")
        {
            TempData["Name"] = name;
            ViewBag.Name = name;

            var model = new List<string>() { "Hej", "På", "Dig", "Potatis" };
            
            return View(nameof(Index),model);
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

        public IActionResult GetValues()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult GetValues(string name, int salary)
        {
            return View();
        }

        public IActionResult GetValuesWithModel()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult GetValuesWithModel(Employee employee)
        {
            return View(); 
        }
    }
}
