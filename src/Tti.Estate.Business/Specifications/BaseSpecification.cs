using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Specifications
{
    public abstract class BaseSpecification<TEntity> : IAsyncSpecification<TEntity>
        where TEntity : BaseEntity
    {
        protected BaseSpecification()
        {
        }

        public Task<bool> IsSatisfiedByAsync(TEntity entity)
        {
            return Task.FromResult(IsSatisfiedBy(entity));
        }

        public abstract bool IsSatisfiedBy(TEntity entity);
    }
}
