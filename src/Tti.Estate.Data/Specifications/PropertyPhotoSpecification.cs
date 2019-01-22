using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class PropertyPhotoSpecification : BaseSpecification<PropertyPhoto>
    {
        public PropertyPhotoSpecification(long propertyId)
            : base(x => x.PropertyId == propertyId)
        {
        }
    }
}
