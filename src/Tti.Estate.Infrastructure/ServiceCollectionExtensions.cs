using Microsoft.Extensions.DependencyInjection;
using System;
using Tti.Estate.Infrastructure.Repositories;
using Tti.Estate.Infrastructure.Services;

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
            
            services.AddScoped<IPhotoBlobRepository, PhotoBlobRepository>();
            services.AddScoped<IImageService, ImageService>();

            return services;
        }
    }
}
