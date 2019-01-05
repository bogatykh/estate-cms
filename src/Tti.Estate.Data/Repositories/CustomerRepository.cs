using System;
using System.Collections.Generic;
using System.Text;

namespace Tti.Estate.Data.Repositories
{
    public class CustomerRepository : BaseRepository
    {
        public CustomerRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
