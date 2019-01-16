using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<IPagedResult<Transaction>> SearchAsync()
        {
            var query = DbContext.Transactions.AsNoTracking();

            return await GetPagedAsync(query);
        }
    }
}
