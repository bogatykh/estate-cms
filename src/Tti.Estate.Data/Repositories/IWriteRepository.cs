using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    public interface IWriteRepository<TEntity>
        where TEntity : BaseEntity
    {
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
