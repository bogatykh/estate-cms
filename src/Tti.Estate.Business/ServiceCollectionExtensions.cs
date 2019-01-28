using Microsoft.Extensions.DependencyInjection;
using System;
using Tti.Estate.Business.Services;
using Tti.Estate.Business.Validators;

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
            services.AddScoped<IPropertyPhotoService, PropertyPhotoService>();
            services.AddScoped<IPropertyService, PropertyService>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IUserValidator, UserValidator>();

            return services;
        }
    }
}
