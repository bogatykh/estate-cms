using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    public interface ICustomerRepository
    {
        Task CreateAsync(Customer entity);
        Task<Customer> GetAsync(long id);
        Task UpdateAsync(Customer entity);
        Task DeleteAsync(Customer entity);
        Task<IPagedResult<Customer>> SearchAsync();
    }
}
