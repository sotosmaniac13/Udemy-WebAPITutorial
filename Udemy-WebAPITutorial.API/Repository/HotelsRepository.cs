using Udemy_WebAPITutorial.API.Contracts;
using Udemy_WebAPITutorial.API.Data;

namespace Udemy_WebAPITutorial.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
