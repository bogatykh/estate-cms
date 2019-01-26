using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public interface ISpecification<TEntity>
        where TEntity : BaseEntity
    {
        Expression<Func<TEntity, bool>> Criteria { get; }

        List<Expression<Func<TEntity, object>>> Includes { get; }

        Expression<Func<TEntity, object>> OrderBy { get; }

        Expression<Func<TEntity, object>> OrderByDescending { get; }

        int Skip { get; }

        int Take { get; }

        bool IsPagingEnabled { get; }
    }
}
