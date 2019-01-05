using System;
using System.Collections.Generic;
using System.Text;

namespace Tti.Estate.Data.Repositories
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
