using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class ContactFilterSpecification : BaseSpecification<Contact>
    {
        public ContactFilterSpecification(long? customerId = null, long? propertyId = null)
            : base(x => x.CustomerId == customerId && x.PropertyId == propertyId)
        {
        }
    }
}
