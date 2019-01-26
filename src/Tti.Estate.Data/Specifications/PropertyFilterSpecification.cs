using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class PropertyFilterSpecification : BaseSpecification<Property>
    {
        public PropertyFilterSpecification(long? id = null, long? userId = null)
            : base(x => (x.Id == id || id == null) && (x.UserId == userId || userId == null))
        {
            AddInclude(x => x.User);
            ApplyOrderByDescending(x => x.Modified);
        }
    }
}
