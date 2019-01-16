using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    public interface IRepository<TEntity> : IReadRepository<TEntity>, IWriteRepository<TEntity>
        where TEntity : BaseEntity
    {
    }
}
