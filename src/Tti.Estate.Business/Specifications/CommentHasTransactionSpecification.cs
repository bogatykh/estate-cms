using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Specifications
{
    public class CommentHasTransactionSpecification : BaseSpecification<Comment>
    {
        public override bool IsSatisfiedBy(Comment entity)
        {
            return entity.TransactionId.HasValue;
        }
    }
}
