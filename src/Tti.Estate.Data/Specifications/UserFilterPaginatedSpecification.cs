namespace Tti.Estate.Data.Specifications
{
    public class UserFilterPaginatedSpecification : UserFilterSpecification
    {
        public UserFilterPaginatedSpecification(int skip, int take, string userName = null)
            : base(userName: userName)
        {
            ApplyPaging(skip, take);
        }
    }
}
