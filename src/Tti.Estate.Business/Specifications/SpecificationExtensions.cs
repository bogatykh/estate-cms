using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Specifications
{
    public static class SpecificationExtensions
    {
        public static IAsyncSpecification<TEntity> And<TEntity>(this IAsyncSpecification<TEntity> @this, IAsyncSpecification<TEntity> other)
            where TEntity : BaseEntity => new AndSpecification<TEntity>(@this, other);

        public static IAsyncSpecification<TEntity> Or<TEntity>(this IAsyncSpecification<TEntity> @this, IAsyncSpecification<TEntity> other)
            where TEntity : BaseEntity => new OrSpecification<TEntity>(@this, other);
    }
}
