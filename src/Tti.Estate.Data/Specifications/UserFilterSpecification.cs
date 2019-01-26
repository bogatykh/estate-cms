using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class UserFilterSpecification : BaseSpecification<User>
    {
        public UserFilterSpecification(bool onlyActive = false, string userName = null)
            : base(x => (x.Status == UserStatus.Active || !onlyActive) && (x.UserName == userName || userName == null))
        {
            ApplyOrderBy(x => x.UserName);
        }
    }
}
