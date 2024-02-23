using Microsoft.AspNetCore.Mvc;
using TrackingSystem.DTO;

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
        public IActionResult AddCountry()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCountry(AddCountryDTO addCountryDTO)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Countries", "Dashboard");
            }
            return View();
        }
    }
}