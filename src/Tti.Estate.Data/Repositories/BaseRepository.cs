using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal abstract class BaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected AppDbContext DbContext { get; }

        protected BaseRepository(AppDbContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        protected async Task<PagedResult<TEntity>> GetPagedAsync(IQueryable<TEntity> query)
        {
            return new PagedResult<TEntity>(
                totalItems: await query.CountAsync(),
                items: await query.ToListAsync()
            );
        }
    }
}
