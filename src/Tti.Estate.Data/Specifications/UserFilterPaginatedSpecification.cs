using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class UserFilterPaginatedSpecification : BaseSpecification<User>
    {
        public UserFilterPaginatedSpecification(int skip, int take, string userName = null)
            : base(x =>x.UserName == userName || userName == null)
        {
            ApplyPaging(skip, take);
        }
    }
}
