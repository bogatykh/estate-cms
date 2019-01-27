using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class UserFilterSpecification : BaseSpecification<User>
    {
        public UserFilterSpecification(bool onlyActive = false, string userName = null, UserRole? role = null, long? excludeId = null)
            : base(x => (x.Status == UserStatus.Active || !onlyActive) &&
                (x.UserName == userName || userName == null) &&
                (!role.HasValue || x.Role == role) &&
                (!excludeId.HasValue || x.Id != excludeId))
        {
            ApplyOrderBy(x => x.UserName);
        }
    }
}
