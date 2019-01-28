using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Specifications
{
    public class ContactHasPropertySpecification : BaseSpecification<Contact>
    {
        public override bool IsSatisfiedBy(Contact entity)
        {
            return entity.PropertyId.HasValue;
        }
    }
}
