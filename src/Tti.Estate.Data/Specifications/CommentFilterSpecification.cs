using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class CommentFilterSpecification : BaseSpecification<Comment>
    {
        public CommentFilterSpecification(long? customerId = null, long? propertyId = null, long? transactionId = null)
            : base(x => x.CustomerId == customerId && x.PropertyId == propertyId && x.TransactionId == transactionId)
        {
            AddInclude(x => x.User);
        }
    }
}
