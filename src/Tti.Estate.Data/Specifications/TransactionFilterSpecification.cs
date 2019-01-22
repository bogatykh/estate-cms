using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class TransactionFilterSpecification : BaseSpecification<Transaction>
    {
        public TransactionFilterSpecification(long? userId = null)
            : base(x => x.UserId == userId || userId == null)
        {
            AddInclude(x => x.User);
        }
    }
}
