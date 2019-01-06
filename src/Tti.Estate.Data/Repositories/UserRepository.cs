using System;
using System.Collections.Generic;
using System.Text;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
