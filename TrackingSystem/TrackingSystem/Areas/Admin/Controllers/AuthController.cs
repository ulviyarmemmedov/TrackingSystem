using Microsoft.AspNetCore.Mvc;

namespace TrackingSystem.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
