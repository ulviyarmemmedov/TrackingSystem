using TrackingSystem.DAL;
using TrackingSystem.Models;
using TrackingSystem.Repository.IRepository;

namespace TrackingSystem.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        private readonly TrackingSystemDbContext _trackingSystemDbContext;
        public CountryRepository(TrackingSystemDbContext dbContext) : base(dbContext)
        {
            _trackingSystemDbContext = dbContext;
        }
    }
}
