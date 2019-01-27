using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class RegionRepository : BaseRepository<Region>, IRegionRepository
    {
        public RegionRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
