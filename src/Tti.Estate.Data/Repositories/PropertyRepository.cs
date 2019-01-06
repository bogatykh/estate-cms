using System;
using System.Collections.Generic;
using System.Text;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    public class PropertyRepository : BaseRepository<Property>
    {
        public PropertyRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
