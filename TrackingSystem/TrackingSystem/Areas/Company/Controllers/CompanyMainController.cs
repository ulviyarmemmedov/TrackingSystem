using Microsoft.AspNetCore.Mvc;

namespace TrackingSystem.Areas.Company.Controllers
{
	[Area("Company")]
	public class CompanyMainController : Controller
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
