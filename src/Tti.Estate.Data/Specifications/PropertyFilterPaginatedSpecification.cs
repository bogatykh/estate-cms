﻿using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class PropertyFilterPaginatedSpecification : BaseSpecification<Property>
    {
        public PropertyFilterPaginatedSpecification(int skip, int take, long? userId = null)
            : base(x => x.UserId == userId || userId == null)
        {
            AddInclude(x => x.User);
            ApplyPaging(skip, take);
        }
    }
}
