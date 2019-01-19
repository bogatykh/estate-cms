using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    internal class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
