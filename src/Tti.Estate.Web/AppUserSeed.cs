using System.Threading.Tasks;
using Tti.Estate.Business.Services;
using Tti.Estate.Data.Entities;

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
                Telephone = "21234567",
                Role = UserRole.Manager,
                Status = UserStatus.Active
            }, "Pa$$word1");

            await userService.CreateAsync(new User()
            {
                UserName = "agent",
                FirstName = "Michael",
                LastName = "Agent",
                Telephone = "29876543",
                Role = UserRole.Agent,
                Status = UserStatus.Active
            }, "Pa$$word1");
        }
    }
}
