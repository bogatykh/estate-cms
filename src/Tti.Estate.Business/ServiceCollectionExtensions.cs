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

            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<IPropertyService, PropertyService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<ICommentValidator, CommentValidator>();
            services.AddScoped<IContactValidator, ContactValidator>();
            services.AddScoped<ICustomerValidator, CustomerValidator>();
            services.AddScoped<IPropertyValidator, PropertyValidator>();
            services.AddScoped<ITransactionValidator, TransactionValidator>();
            services.AddScoped<IUserValidator, UserValidator>();

            return services;
        }
    }
}
