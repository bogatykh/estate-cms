using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business
{
    public interface IValidator<TEntity, TAction>
        where TEntity : BaseEntity
        where TAction : struct
    {
        Task ValidateAsync(TEntity entity, TAction action);
    }
}
