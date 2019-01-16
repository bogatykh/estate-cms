using System;
using System.Linq.Expressions;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public interface ISpecification<TEntity>
        where TEntity : BaseEntity
    {
        Expression<Func<TEntity, bool>> Criteria { get; }
    }
}
