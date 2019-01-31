using System.Linq;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class CustomerFilterSpecification : BaseSpecification<Customer>
    {
        public CustomerFilterSpecification(long? id = null, string term = null, long? userId = null)
            : base(x => (!id.HasValue || x.Id == id) &&
                (term == null || x.Id.ToString() == term || x.Contacts.Any(c => c.FirstName.Contains(term) || c.LastName.Contains(term) || c.Telephone == term || c.Email.Contains(term))) &&
                (!userId.HasValue || x.UserId == userId))
        {
            AddInclude(x => x.User);
            ApplyOrderByDescending(x => x.Modified);
        }
    }
}
