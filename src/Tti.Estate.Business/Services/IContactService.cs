using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Services
{
    public interface IContactService
    {
        Task CreateAsync(Contact contact);

        Task<Contact> GetAsync(long id);

        Task<IEnumerable<Contact>> ListAsync(long? customerId = null, long? propertyId = null);

        Task UpdateAsync(Contact contact);

        Task DeleteAsync(Contact contact);
    }
}
