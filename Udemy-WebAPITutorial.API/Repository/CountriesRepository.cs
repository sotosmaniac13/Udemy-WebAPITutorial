using Microsoft.EntityFrameworkCore;
using Udemy_WebAPITutorial.API.Contracts;
using Udemy_WebAPITutorial.API.Data;

namespace Udemy_WebAPITutorial.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly ApplicationDbContext _context;

        public CountriesRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries
                .Include(c => c.Hotels)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
