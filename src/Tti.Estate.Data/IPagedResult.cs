using System.Collections.Generic;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data
{
    public interface IPagedResult
    {
        int TotalItems { get; }
    }

    public interface IPagedResult<TEntity> : IPagedResult
        where TEntity : BaseEntity
    {
        IEnumerable<TEntity> Items { get; }
    }
}
