using Udemy_WebAPITutorial.API.Data;

namespace Udemy_WebAPITutorial.API.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
