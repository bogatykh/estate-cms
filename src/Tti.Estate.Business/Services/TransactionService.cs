using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Dto;
using Tti.Estate.Business.Validators;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;

namespace Tti.Estate.Business.Services
{
    internal class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IPropertyRepository _propertyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITransactionValidator _transactionValidator;

        public TransactionService(ITransactionRepository transactionRepository, IPropertyRepository propertyRepository, IUnitOfWork unitOfWork, ITransactionValidator transactionValidator)
        {
            _transactionRepository = transactionRepository;
            _propertyRepository = propertyRepository;
            _unitOfWork = unitOfWork;
            _transactionValidator = transactionValidator;
        }

        public async Task CreateAsync(Transaction transaction)
        {
            await _transactionValidator.ValidateAsync(transaction, TransactionAction.Create);

            _transactionRepository.Create(transaction);

            await _unitOfWork.SaveAsync();
        }

        public async Task<Transaction> GetAsync(long id)
        {
            var spec = new TransactionFilterSpecification(id: id);

            return await _transactionRepository.SingleAsync(spec);
        }

        public async Task<IPagedResult<Transaction>> ListAsync(int pageIndex, int pageSize,
            long? userId = null,
            TransactionType? transactionType = null,
            TransactionStatus? status = null,
            DateTime? dateFrom = null,
            DateTime? dateTo = null)
        {
            var filterSpecification = new TransactionFilterSpecification(
                userId: userId,
                transactionType: transactionType,
                status: status,
                dateFrom: dateFrom,
                dateTo: dateTo
            );
            var filterPaginatedSpecification = new TransactionFilterPaginatedSpecification(pageIndex * pageSize, pageSize,
                userId: userId,
                transactionType: transactionType,
                status: status,
                dateFrom: dateFrom,
                dateTo: dateTo
            );
            
            var items = await _transactionRepository.ListAsync(filterPaginatedSpecification);
            var totalItems = await _transactionRepository.CountAsync(filterSpecification);

            return new PagedResult<Transaction>(pageIndex, pageSize, totalItems, items);
        }

        public async Task UpdateAsync(Transaction transaction)
        {
            await _transactionValidator.ValidateAsync(transaction, TransactionAction.Update);

            transaction.Modified = DateTime.UtcNow;

            _transactionRepository.Update(transaction);

            await _unitOfWork.SaveAsync();
        }

        public async Task<OperationResult> DeleteAsync(long id)
        {
            var transaction = await _transactionRepository.GetAsync(id);

            if (transaction == null)
            {
                return OperationResult.NotFound;
            }

            await _transactionValidator.ValidateAsync(transaction, TransactionAction.Delete);

            _transactionRepository.Delete(transaction);

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
        }

        public async Task<OperationResult> SubmitAsync(long id)
        {
            var transaction = await _transactionRepository.GetAsync(id);

            if (transaction == null)
            {
                return OperationResult.NotFound;
            }

            await _transactionValidator.ValidateAsync(transaction, TransactionAction.Submit);
            
            transaction.Status = TransactionStatus.Approving;

            _transactionRepository.Update(transaction);

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
        }

        public async Task<OperationResult> ApproveAsync(long id)
        {
            var transaction = await _transactionRepository.GetAsync(id);

            if (transaction == null)
            {
                return OperationResult.NotFound;
            }

            await _transactionValidator.ValidateAsync(transaction, TransactionAction.Approve);

            transaction.Status = TransactionStatus.Approved;

            _transactionRepository.Update(transaction);

            var property = await _propertyRepository.GetAsync(transaction.PropertyId);

            property.Status = PropertyStatus.Transaction;

            _propertyRepository.Update(property);

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
        }

        public async Task<OperationResult> RejectAsync(long id)
        {
            var transaction = await _transactionRepository.GetAsync(id);

            if (transaction == null)
            {
                return OperationResult.NotFound;
            }

            await _transactionValidator.ValidateAsync(transaction, TransactionAction.Reject);

            transaction.Status = TransactionStatus.Draft;

            _transactionRepository.Update(transaction);

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
        }
    }
}
