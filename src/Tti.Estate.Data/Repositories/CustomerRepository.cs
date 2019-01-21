using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
