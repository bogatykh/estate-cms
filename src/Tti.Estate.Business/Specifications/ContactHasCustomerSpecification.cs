using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Specifications
{
    public class ContactHasCustomerSpecification : BaseSpecification<Contact>
    {
        public override bool IsSatisfiedBy(Contact entity)
        {
            return entity.CustomerId.HasValue;
        }
    }
}
