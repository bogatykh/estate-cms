using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class PhotoSpecification : BaseSpecification<Photo>
    {
        public PhotoSpecification(long propertyId)
            : base(x => x.PropertyId == propertyId)
        {
        }
    }
}
