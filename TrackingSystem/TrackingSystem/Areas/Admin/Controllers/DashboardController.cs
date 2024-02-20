using Microsoft.AspNetCore.Mvc;

namespace TrackingSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Countries()
        {
            return View();
        }
        public IActionResult AddCountry(int a)
        {
            return View();
        }
    }
}