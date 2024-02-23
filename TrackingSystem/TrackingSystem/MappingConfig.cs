using AutoMapper;
using TrackingSystem.DTO;
using TrackingSystem.Models;

namespace TrackingSystem
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Country, AddCountryDTO>().ReverseMap();
        }
    }
}
