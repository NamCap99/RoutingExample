using Microsoft.AspNetCore.Mvc;

namespace RoutingExample.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController :Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to Admin Dashboard"); 
        }
    }
}
