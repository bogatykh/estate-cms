using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Dto;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Services
{
    public interface ITransactionService
    {
        Task CreateAsync(Transaction transaction);
        Task<Transaction> GetAsync(long id);
        Task<IPagedResult<Transaction>> ListAsync(int pageIndex, int pageSize,
            long? userId = null,
            TransactionType? transactionType = null,
            TransactionStatus? status = null,
            DateTime? dateFrom = null,
            DateTime? dateTo = null);
        Task UpdateAsync(Transaction transaction);
        Task<OperationResult> DeleteAsync(long id);
        Task<OperationResult> SubmitAsync(long id);
        Task<OperationResult> ApproveAsync(long id);
        Task<OperationResult> RejectAsync(long id);
    }
}
