using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class DbRepository<TEntity> : BaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        public DbRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
