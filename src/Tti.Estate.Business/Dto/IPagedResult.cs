using System.Collections.Generic;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Dto
{
    public interface IPagedResult
    {
        int PageIndex { get; }

        int PageSize { get; }

        int TotalItems { get; }
    }

    public interface IPagedResult<TEntity> : IPagedResult
        where TEntity : BaseEntity
    {
        IEnumerable<TEntity> Items { get; }
    }
}
