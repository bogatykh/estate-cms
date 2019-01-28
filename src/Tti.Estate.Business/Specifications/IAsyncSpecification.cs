using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Specifications
{
    public interface IAsyncSpecification<TEntity>
        where TEntity : BaseEntity
    {
        Task<bool> IsSatisfiedByAsync(TEntity entity);
    }
}
