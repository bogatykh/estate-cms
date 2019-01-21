using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
