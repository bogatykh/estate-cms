using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    public interface IPropertyRepository : IRepository<Property>
    {
        Task<IPagedResult<Property>> SearchAsync();
    }
}
