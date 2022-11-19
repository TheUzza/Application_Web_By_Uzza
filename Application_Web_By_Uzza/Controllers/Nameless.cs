using Microsoft.AspNetCore.Mvc;

namespace Application_Web_By_Uzza.Controllers
{
    public class Nameless : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();

        }
        public IActionResult About()
        {
            return View();
        }

    }
}
