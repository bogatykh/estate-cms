using Microsoft.EntityFrameworkCore;
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

        public async Task<IPagedResult<Customer>> SearchAsync()
        {
            var query = DbContext.Customers.AsNoTracking();

            return await GetPagedAsync(query);
        }
    }
}
