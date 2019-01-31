using Microsoft.Extensions.Localization;
using System;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;

namespace Tti.Estate.Business.Validators
{
    internal class TransactionValidator : ITransactionValidator
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IStringLocalizer _localizer;

        public TransactionValidator(ITransactionRepository transactionRepository, IStringLocalizer<TransactionValidator> localizer)
        {
            _transactionRepository = transactionRepository;
            _localizer = localizer;
        }

        public async Task ValidateAsync(Transaction entity, TransactionAction action)
        {
            switch (action)
            {
                case TransactionAction.Create:
                    await ValidateCreateAsync(entity);
                    break;
                case TransactionAction.Update:
                    break;
                case TransactionAction.Delete:
                    break;
                case TransactionAction.Submit:
                    break;
                case TransactionAction.Approve:
                    break;
                case TransactionAction.Reject:
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private async Task ValidateCreateAsync(Transaction entity)
        {
        }
    }
}
