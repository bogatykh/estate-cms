using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
