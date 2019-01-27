﻿using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class PropertyFilterSpecification : BaseSpecification<Property>
    {
        public PropertyFilterSpecification(long? id = null,
            long? userId = null,
            PropertyType? propertyType = null,
            PropertyStatus? status = null,
            TransactionType? transactionType = null,
            decimal? priceFrom = null,
            decimal? priceTo = null)
            : base(x => (!id.HasValue || x.Id == id) &&
                (!userId.HasValue || x.UserId == userId) &&
                (!propertyType.HasValue || x.PropertyType == propertyType) &&
                (!status.HasValue || x.Status == status) &&
                (!transactionType.HasValue || x.TransactionType == transactionType) &&
                (!priceFrom.HasValue || x.Price >= priceFrom) &&
                (!priceTo.HasValue || x.Price <= priceTo))
        {
            AddInclude(x => x.User);
            ApplyOrderByDescending(x => x.Modified);
        }
    }
}
