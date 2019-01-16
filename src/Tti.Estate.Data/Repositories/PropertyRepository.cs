using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class PropertyRepository : BaseRepository<Property>, IPropertyRepository
    {
        public PropertyRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<IPagedResult<Property>> SearchAsync()
        {
            var query = DbContext.Properties.AsNoTracking();

            return await GetPagedAsync(query);
        }
    }
}
