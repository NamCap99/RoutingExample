using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace RoutingExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to Home Index");
        }

        public IActionResult About()
        {
            return Content("This is the About Page");
        }
    }
}
