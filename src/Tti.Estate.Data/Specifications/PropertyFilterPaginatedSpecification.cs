using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class PropertyFilterPaginatedSpecification : PropertyFilterSpecification
    {
        public PropertyFilterPaginatedSpecification(int skip, int take,
            long? userId = null,
            PropertyType? propertyType = null,
            PropertyStatus? status = null,
            TransactionType? transactionType = null,
            decimal? priceFrom = null,
            decimal? priceTo = null)
            : base(userId: userId, propertyType: propertyType, status: status, transactionType: transactionType, priceFrom: priceFrom, priceTo: priceTo)
        {
            ApplyPaging(skip, take);
        }
    }
}
