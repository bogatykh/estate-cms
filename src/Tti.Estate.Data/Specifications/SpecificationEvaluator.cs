using Microsoft.EntityFrameworkCore;
using System.Linq;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    internal class SpecificationEvaluator<TEntity>
        where TEntity : BaseEntity
    {
        internal static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specification)
        {
            var query = inputQuery;
            
            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }

            query = specification.Includes.
                Aggregate(query, (src, include) => src.Include(include));

            if (specification.OrderBy != null)
            {
                query = query.OrderBy(specification.OrderBy);
            }
            else if (specification.OrderByDescending != null)
            {
                query = query.OrderByDescending(specification.OrderByDescending);
            }

            if (specification.IsPagingEnabled)
            {
                query = query.
                    Skip(specification.Skip).
                    Take(specification.Take);
            }

            return query;
        }
    }
}
