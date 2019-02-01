using System.Linq;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class PropertyFilterSpecification : BaseSpecification<Property>
    {
        public PropertyFilterSpecification(long? id = null,
            long? userId = null,
            PropertyType? propertyType = null,
            PropertyStatus? status = null,
            TransactionType? transactionType = null,
            long? countyId = null,
            long? cityId = null,
            decimal? priceFrom = null,
            decimal? priceTo = null,
            string telephone = null)
            : base(x => (!id.HasValue || x.Id == id) &&
                (!userId.HasValue || x.UserId == userId) &&
                (!propertyType.HasValue || x.PropertyType == propertyType) &&
                (!status.HasValue || x.Status == status) &&
                (!transactionType.HasValue || x.TransactionType == transactionType) &&
                (!countyId.HasValue || x.CountyId == countyId) &&
                (!cityId.HasValue || x.CityId == cityId) &&
                (!priceFrom.HasValue || x.Price >= priceFrom) &&
                (!priceTo.HasValue || x.Price <= priceTo) &&
                (telephone == null || x.Contacts.Any(c => c.Telephone == telephone)))
        {
            AddInclude(x => x.County);
            AddInclude(x => x.City);
            AddInclude(x => x.User);
            ApplyOrderByDescending(x => x.Modified);
        }
    }
}
