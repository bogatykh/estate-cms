namespace Tti.Estate.Data.Specifications
{
    public class CustomerFilterPaginatedSpecification : CustomerFilterSpecification
    {
        public CustomerFilterPaginatedSpecification(int skip, int take, string term = null, long? userId = null)
            : base(term: term, userId: userId)
        {
            AddInclude(x => x.Contacts);
            ApplyPaging(skip, take);
        }
    }
}
