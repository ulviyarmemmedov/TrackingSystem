using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
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
        public async Task<IActionResult> Countries()
        {
            var items=await _countryRepository.GetAllAsync(x=>x.Status==true);
            return View(items);
        }
        public IActionResult AddCountry()
        {
            ViewData["name"] = "Add country";
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
            ViewData["name"] = "Add country";
            return View();
        }
        public async Task<IActionResult>UpdateCountry(int id)
        {
            var country = await _countryRepository.GetAsync(c=>c.Id==id&&c.Status==true);
            if(country == null)
            {
                return RedirectToAction("Countries", "Dashboard");
            }
            ViewData["name"] = "Update country";
            return View("AddCountry", _mapper.Map<AddCountryDTO>(country));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>UpdateCountry(AddCountryDTO addCountryDTO)
        {
            if (ModelState.IsValid)
            {
                var country = await _countryRepository.GetAsync(c => c.Id == addCountryDTO.ID && c.Status == true, false);
                if(country != null)
                {
                    country=_mapper.Map<Country>(addCountryDTO);
                    await _countryRepository.UpdateAsync(country);
                }
                return RedirectToAction("Countries", "Dashboard");
            }
            ViewData["name"] = "Update country";
            return View("AddCountry");
        }

    }
}

