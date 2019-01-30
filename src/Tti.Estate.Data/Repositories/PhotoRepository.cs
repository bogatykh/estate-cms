using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class PhotoRepository : BaseRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
