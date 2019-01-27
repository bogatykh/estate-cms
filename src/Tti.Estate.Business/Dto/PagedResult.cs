using System.Collections.Generic;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Dto
{
    internal class PagedResult : IPagedResult
    {
        public PagedResult(int pageIndex, int pageSize, int totalItems)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalItems = totalItems;
        }

        public int PageIndex { get; }

        public int PageSize { get; }

        public int TotalItems { get; }
    }

    internal class PagedResult<TEntity> : PagedResult, IPagedResult<TEntity>
        where TEntity : BaseEntity
    {
        public PagedResult(int pageIndex, int pageSize, int totalItems, IEnumerable<TEntity> items)
            : base(pageIndex: pageIndex, pageSize: pageSize, totalItems: totalItems)
        {
            Items = items;
        }

        public IEnumerable<TEntity> Items { get; }
    }
}
