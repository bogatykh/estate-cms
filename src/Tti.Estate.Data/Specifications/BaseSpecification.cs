using System;
using System.Linq.Expressions;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public abstract class BaseSpecification<TEntity> : ISpecification<TEntity>
        where TEntity : BaseEntity
    {
        protected BaseSpecification(Expression<Func<TEntity, bool>> criteria)
        {
            Criteria = criteria;
        }
        public Expression<Func<TEntity, bool>> Criteria { get; }
    }
}
