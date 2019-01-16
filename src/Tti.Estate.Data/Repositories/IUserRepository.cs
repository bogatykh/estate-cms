using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    public interface IUserRepository : IRepository<User>, IReadRepository<User>, IWriteRepository<User>
    {
        Task<IPagedResult<User>> SearchAsync();
    }
}
