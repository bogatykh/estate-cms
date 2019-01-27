using System.Threading.Tasks;
using Tti.Estate.Business.Dto;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Services
{
    public interface IUserService
    {
        Task CreateAsync(User user, string password);
        Task<User> GetAsync(long id);
        Task<IPagedResult<User>> ListAsync(int pageIndex, int pageSize);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);
        Task BlockAsync(User user);
        Task UnblockAsync(User user);
        Task<User> ValidateAsync(string userName, string password);
    }
}
