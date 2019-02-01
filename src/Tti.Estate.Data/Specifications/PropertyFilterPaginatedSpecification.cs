using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class PropertyFilterPaginatedSpecification : PropertyFilterSpecification
    {
        public PropertyFilterPaginatedSpecification(int skip, int take,
            long? id = null,
            long? userId = null,
            PropertyType? propertyType = null,
            PropertyStatus? status = null,
            TransactionType? transactionType = null,
            long? countyId = null,
            long? cityId = null,
            decimal? priceFrom = null,
            decimal? priceTo = null,
            string telephone = null)
            : base(id: id, userId: userId, propertyType: propertyType, status: status, transactionType: transactionType, countyId: countyId, cityId: cityId, priceFrom: priceFrom, priceTo: priceTo, telephone: telephone)
        {
            ApplyPaging(skip, take);
        }
    }
}
