namespace Tti.Estate.Data.Specifications
{
    public class TransactionFilterPaginatedSpecification : TransactionFilterSpecification
    {
        public TransactionFilterPaginatedSpecification(int skip, int take, long? userId = null)
            : base(userId: userId)
        {
            ApplyPaging(skip, take);
        }
    }
}
