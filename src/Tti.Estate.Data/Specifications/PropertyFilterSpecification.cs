using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class PropertyFilterSpecification : BaseSpecification<Property>
    {
        public PropertyFilterSpecification(long? userId = null)
            : base(x => x.UserId == userId || userId == null)
        {
            AddInclude(x => x.User);
        }
    }
}
