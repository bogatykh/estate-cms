using Microsoft.Extensions.DependencyInjection;
using System;
using Tti.Estate.Data.Repositories;

namespace Tti.Estate.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped(typeof(IRepository<>), typeof(DbRepository<>));
            services.AddScoped(typeof(IReadRepository<>), typeof(DbRepository<>));

            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<ICountyRepository, CountyRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();
            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
