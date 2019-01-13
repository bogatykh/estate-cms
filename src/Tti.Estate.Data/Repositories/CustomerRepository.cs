using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task CreateAsync(Customer entity)
        {
            DbContext.Customers.Add(entity);

            await DbContext.SaveChangesAsync();
        }

        public async Task<Customer> GetAsync(long id)
        {
            return await DbContext.Customers.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Customer entity)
        {
            DbContext.Customers.Update(entity);

            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Customer entity)
        {
            DbContext.Customers.Remove(entity);

            await DbContext.SaveChangesAsync();
        }

        public async Task<IPagedResult<Customer>> SearchAsync()
        {
            var query = DbContext.Customers.AsNoTracking();

            return await GetPagedAsync(query);
        }
    }
}
