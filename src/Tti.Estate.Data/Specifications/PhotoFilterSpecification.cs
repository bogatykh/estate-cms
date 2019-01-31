using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class PhotoFilterSpecification : BaseSpecification<Photo>
    {
        public PhotoFilterSpecification(long propertyId)
            : base(x => x.PropertyId == propertyId)
        {
        }
    }
}
