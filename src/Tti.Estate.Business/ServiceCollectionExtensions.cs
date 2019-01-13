using Microsoft.Extensions.DependencyInjection;
using System;
using Tti.Estate.Business.Services;

namespace Tti.Estate.Business
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IPropertyService, PropertyService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
