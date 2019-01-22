using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Infrastructure.Services
{
    public interface IUserService
    {
        Task CreateAsync(User user, string password);
        Task<User> ValidateUserAsync(string userName, string password);
    }
}
