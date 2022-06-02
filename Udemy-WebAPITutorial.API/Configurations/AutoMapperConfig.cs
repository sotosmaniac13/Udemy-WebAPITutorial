using AutoMapper;
using Udemy_WebAPITutorial.API.Data;
using Udemy_WebAPITutorial.API.Models.Country;
using Udemy_WebAPITutorial.API.Models.Hotel;

namespace Udemy_WebAPITutorial.API.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Country, GetCountryDTO>().ReverseMap();
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, UpdateCountryDTO>().ReverseMap();

            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
        }
    }
}
