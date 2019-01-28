using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Specifications
{
    public class OrSpecification<TEntity> : IAsyncSpecification<TEntity>
        where TEntity : BaseEntity
    {
        private readonly IAsyncSpecification<TEntity> _leftSpec;
        private readonly IAsyncSpecification<TEntity> _rightSpec;

        public OrSpecification(IAsyncSpecification<TEntity> leftSpec, IAsyncSpecification<TEntity> rightSpec)
        {
            _leftSpec = leftSpec;
            _rightSpec = rightSpec;
        }

        public async Task<bool> IsSatisfiedByAsync(TEntity entity)
        {
            return await _leftSpec.IsSatisfiedByAsync(entity) || await _rightSpec.IsSatisfiedByAsync(entity);
        }
    }
}
