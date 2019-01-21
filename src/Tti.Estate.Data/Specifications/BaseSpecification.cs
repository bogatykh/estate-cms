using System;
using System.Collections.Generic;
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

        public List<Expression<Func<TEntity, object>>> Includes { get; } = new List<Expression<Func<TEntity, object>>>();
        
        public int Skip { get; private set; }

        public int Take { get; private set; }

        public bool IsPagingEnabled { get; private set; }

        protected virtual void AddInclude(Expression<Func<TEntity, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        protected virtual void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }
    }
}
