using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Specifications
{
    public class CommentHasCustomerSpecification : BaseSpecification<Comment>
    {
        public override bool IsSatisfiedBy(Comment entity)
        {
            return entity.CustomerId.HasValue;
        }
    }
}
