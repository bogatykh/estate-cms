using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<IPagedResult<User>> SearchAsync()
        {
            var query = DbContext.Users.AsNoTracking();

            return await GetPagedAsync(query);
        }
    }
}
