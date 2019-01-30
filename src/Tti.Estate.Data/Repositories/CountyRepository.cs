using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class CountyRepository : BaseRepository<County>, ICountyRepository
    {
        public CountyRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
