using System.Collections.Generic;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data
{
    internal class PagedResult
    {
        public int TotalItems { get; }

        protected PagedResult(int totalItems)
        {
            TotalItems = totalItems;
        }
    }

    internal class PagedResult<TEntity> : PagedResult, IPagedResult<TEntity>
        where TEntity : BaseEntity
    {
        public IEnumerable<TEntity> Items { get; }

        public PagedResult(int totalItems, List<TEntity> items)
            : base(totalItems)
        {
            Items = items.AsReadOnly();
        }
    }
}
