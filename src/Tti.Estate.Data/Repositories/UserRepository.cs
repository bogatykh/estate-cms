﻿using System;
using System.Collections.Generic;
using System.Text;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
