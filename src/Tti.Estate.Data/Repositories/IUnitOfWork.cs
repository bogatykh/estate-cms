using System.Threading.Tasks;

namespace Tti.Estate.Data.Repositories
{
    public interface IUnitOfWork
    {
        Task SaveAsync();
    }
}