using System;
using System.Collections.Generic;
using System.Text;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class PropertyRepository : BaseRepository<Property>, IPropertyRepository
    {
        public PropertyRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
