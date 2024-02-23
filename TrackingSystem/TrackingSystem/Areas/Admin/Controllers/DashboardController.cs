using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrackingSystem.DTO;
using TrackingSystem.Models;
using TrackingSystem.Repository.IRepository;

namespace TrackingSystem.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;
        public DashboardController(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }
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
        public async Task<IActionResult> AddCountry(AddCountryDTO addCountryDTO)
        {
            if (ModelState.IsValid)
            {
                await _countryRepository.CreateAsync(_mapper.Map<Country>(addCountryDTO));
                return RedirectToAction("Countries", "Dashboard");
            }
            return View();
        }
    }
}