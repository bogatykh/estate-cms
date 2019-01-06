using System;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    public abstract class BaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly AppDbContext _dbContext;

        protected BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
    }
}
