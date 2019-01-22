using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Tti.Estate.Data;
using Tti.Estate.Infrastructure.Services;

namespace Tti.Estate.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var userService = services.GetRequiredService<IUserService>();
                AppUserSeed.SeedAsync(userService).Wait();

                var dbContext = services.GetRequiredService<AppDbContext>();
                AppDbContextSeed.SeedRandomDataAsync(dbContext).Wait();
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
