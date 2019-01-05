using System;
using System.Collections.Generic;
using System.Text;

namespace Tti.Estate.Data.Repositories
{
    public abstract class BaseRepository
    {
        private readonly AppDbContext _dbContext;

        protected BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
    }
}
