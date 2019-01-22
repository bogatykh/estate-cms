using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class CustomerFilterSpecification : BaseSpecification<Customer>
    {
        public CustomerFilterSpecification(long? userId = null)
            : base(x => x.UserId == userId || userId == null)
        {
            AddInclude(x => x.User);
        }
    }
}
