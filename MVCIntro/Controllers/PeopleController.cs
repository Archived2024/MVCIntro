using Microsoft.AspNetCore.Mvc;

namespace MVCIntro.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
