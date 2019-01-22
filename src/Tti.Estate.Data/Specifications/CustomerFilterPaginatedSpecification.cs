namespace Tti.Estate.Data.Specifications
{
    public class CustomerFilterPaginatedSpecification : CustomerFilterSpecification
    {
        public CustomerFilterPaginatedSpecification(int skip, int take, long? userId = null)
            : base(userId: userId)
        {
            ApplyPaging(skip, take);
        }
    }
}
