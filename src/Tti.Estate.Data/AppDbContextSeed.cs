using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data
{
    public static class AppDbContextSeed
    {
        public static async Task SeedRandomDataAsync(AppDbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            var random = new Random();

            int userCount = dbContext.Users.Count();

            // Create properties
            for (int i = 0; i < random.Next(1000, 2000); i++)
            {
                var transactionType = random.GetEnum<TransactionType>();
                var county = await random.GetEntityAsync(dbContext.Counties);

                DateTime created = DateTime.UtcNow.AddHours(-random.Next(1000));

                dbContext.Properties.Add(new Property()
                {
                    User = await random.GetEntityAsync(dbContext.Users),
                    PropertyType = random.GetEnum<PropertyType>(),
                    TransactionType = transactionType,
                    Status = random.GetEnum<PropertyStatus>(),
                    Price = transactionType == TransactionType.Rent ? random.Next(100, 1500) : random.Next(10000, 200000),
                    Area = Convert.ToDecimal(random.NextDouble() * random.Next(50, 1000)),
                    County = county,
                    City = await random.GetEntityAsync(dbContext.Cities.Where(x => x.CountyId == county.Id)),
                    Created = created,
                    Modified = created
                });
            }

            // Create customers
            for (int i = 0; i < random.Next(1000, 2000); i++)
            {
                DateTime created = DateTime.UtcNow.AddHours(-random.Next(1000));

                dbContext.Customers.Add(new Customer()
                {
                    User = await random.GetEntityAsync(dbContext.Users),
                    Created = created,
                    Modified = created
                });
            }

            // Create transactions
            for (int i = 0; i < random.Next(200, 500); i++)
            {
                var companyPercent = Convert.ToByte(random.NextDouble() * 100);

                var property = dbContext.Properties.Local.OrderBy(x => Guid.NewGuid()).First();

                dbContext.Transactions.Add(new Transaction()
                {
                    User = await random.GetEntityAsync(dbContext.Users),
                    TransactionType = property.TransactionType,
                    Status = random.GetEnum<TransactionStatus>(),
                    Property = property,
                    Customer = await random.GetEntityAsync(dbContext.Customers),
                    Date = property.Created.Date,
                    Amount = property.Price,
                    CompanyPercent = companyPercent,
                    UserPercent = Convert.ToByte(100 - companyPercent),
                    Created = property.Created,
                    Modified = property.Modified
                });
            }

            await dbContext.SaveChangesAsync();
        }

        private static TEnum GetEnum<TEnum>(this Random random)
             where TEnum : struct
        {
            var values = Enum.GetValues(typeof(TEnum));

            return (TEnum)values.GetValue(random.Next(values.Length));
        }

        private static async Task<TEntity> GetEntityAsync<TEntity>(this Random random, IQueryable<TEntity> query)
            where TEntity : BaseEntity
        {
            var skip = (int)(random.NextDouble() * await query.CountAsync());

            return await query.
                OrderBy(o => o.Id).
                Skip(skip).
                Take(1).
                FirstOrDefaultAsync();
        }
    }
}
