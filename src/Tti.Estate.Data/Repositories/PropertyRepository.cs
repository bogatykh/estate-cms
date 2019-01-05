using System;
using System.Collections.Generic;
using System.Text;

namespace Tti.Estate.Data.Repositories
{
    public class PropertyRepository : BaseRepository
    {
        public PropertyRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
