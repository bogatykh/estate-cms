namespace Tti.Estate.Data.Specifications
{
    public class PropertyFilterPaginatedSpecification : PropertyFilterSpecification
    {
        public PropertyFilterPaginatedSpecification(int skip, int take, long? userId = null)
            : base(userId: userId)
        {
            ApplyPaging(skip, take);
        }
    }
}
