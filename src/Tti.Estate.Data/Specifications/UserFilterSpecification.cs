using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class UserFilterSpecification : BaseSpecification<User>
    {
        public UserFilterSpecification(bool onlyActive = false)
            : base(x => x.Status == UserStatus.Active || !onlyActive)
        {
        }
    }
}
