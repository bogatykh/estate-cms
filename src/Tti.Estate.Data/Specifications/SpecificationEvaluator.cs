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

            return query;
        }
    }
}
