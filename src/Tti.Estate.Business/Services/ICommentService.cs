using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Services
{
    public interface ICommentService
    {
        Task CreateAsync(Comment comment);

        Task<IEnumerable<Comment>> ListAsync(long? customerId = null, long? propertyId = null, long? transactionId = null);
    }
}
