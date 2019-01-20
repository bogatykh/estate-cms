using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class PropertyPhotoRepository : BaseRepository<PropertyPhoto>, IPropertyPhotoRepository
    {
        public PropertyPhotoRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
