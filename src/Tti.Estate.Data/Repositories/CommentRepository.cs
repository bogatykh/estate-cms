using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
