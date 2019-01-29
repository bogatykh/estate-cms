﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data
{
    public static class AppDbContextSeed
    {
        public static async Task SeedAsync(AppDbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            dbContext.Regions.AddRange(GetPreconfiguredRegions());

            await dbContext.SaveChangesAsync();
        }

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
                
                dbContext.Properties.Add(new Property()
                {
                    User = await random.GetEntityAsync(dbContext.Users),
                    PropertyType = random.GetEnum<PropertyType>(),
                    TransactionType = transactionType,
                    Status = random.GetEnum<PropertyStatus>(),
                    Price = transactionType == TransactionType.Rent ? random.Next(100, 1500) : random.Next(10000, 200000),
                    Area = Convert.ToDecimal(random.NextDouble() * random.Next(50, 1000))
                });
            }

            // Create customers
            for (int i = 0; i < random.Next(1000, 2000); i++)
            {
                dbContext.Customers.Add(new Customer()
                {
                    User = await random.GetEntityAsync(dbContext.Users)
                });
            }

            // Create transactions
            //for (int i = 0; i < random.Next(200, 500); i++)
            //{
            //    var companyPercent = Convert.ToDecimal(random.NextDouble() * 100);

            //    var property = await random.GetEntityAsync(dbContext.Properties);

            //    dbContext.Transactions.Add(new Transaction()
            //    {
            //        User = await random.GetEntityAsync(dbContext.Users),
            //        TransactionType = property.TransactionType,
            //        Status = random.GetEnum<TransactionStatus>(),
            //        Property = property,
            //        Customer = await random.GetEntityAsync(dbContext.Customers),
            //        Date = property.Created.Date,
            //        Amount = property.Price,
            //        CompanyPercent = companyPercent,
            //        UserPercent = 100 - companyPercent
            //    });
            //}

            await dbContext.SaveChangesAsync();
        }

        private static TEnum GetEnum<TEnum>(this Random random)
             where TEnum : struct
        {
            var values = Enum.GetValues(typeof(TEnum));

            return (TEnum)values.GetValue(random.Next(values.Length - 1));
        }

        private static async Task<TEntity> GetEntityAsync<TEntity>(this Random random, DbSet<TEntity> dbSet)
            where TEntity : BaseEntity
        {
            var skip = (int)(random.NextDouble() * await dbSet.CountAsync());

            return await dbSet.
                OrderBy(o => o.Id).
                Skip(skip).
                Take(1).
                FirstOrDefaultAsync();
        }
        static IEnumerable<Region> GetPreconfiguredRegions()
        {
            return new List<Region>()
            {
                new Region() { Name = "Rīga", Code = "0010000" }
            };
        }
    }
}
