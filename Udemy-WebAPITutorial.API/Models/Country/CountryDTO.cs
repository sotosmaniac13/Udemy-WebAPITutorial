using Udemy_WebAPITutorial.API.Models.Hotel;

namespace Udemy_WebAPITutorial.API.Models.Country
{
    public class CountryDTO : BaseCountryDTO
    {
        public int Id { get; set; }

        public List<HotelDTO> Hotels { get; set; }
    }
}
