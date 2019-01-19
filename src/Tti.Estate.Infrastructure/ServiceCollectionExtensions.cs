using Microsoft.Extensions.DependencyInjection;
using System;
using Tti.Estate.Business.Services;

namespace Tti.Estate.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
