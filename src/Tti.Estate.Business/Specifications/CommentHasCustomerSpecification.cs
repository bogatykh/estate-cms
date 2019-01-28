using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Specifications
{
    public class CommentHasPropertySpecification : BaseSpecification<Comment>
    {
        public override bool IsSatisfiedBy(Comment entity)
        {
            return entity.PropertyId.HasValue;
        }
    }
}
