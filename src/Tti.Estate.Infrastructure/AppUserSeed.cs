using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Infrastructure.Services;

namespace Tti.Estate.Web
{
    public static class AppUserSeed
    {
        public static async Task SeedAsync(IUserService userService)
        {
            await userService.CreateAsync(new User()
            {
                UserName = "manager",
                FirstName = "John",
                LastName = "Manager",
                Role = UserRole.Manager,
                Status = UserStatus.Active
            }, "Pa$$word1");

            await userService.CreateAsync(new User()
            {
                UserName = "agent",
                FirstName = "Michael",
                LastName = "Agent",
                Role = UserRole.Agent,
                Status = UserStatus.Active
            }, "Pa$$word1");
        }
    }
}
