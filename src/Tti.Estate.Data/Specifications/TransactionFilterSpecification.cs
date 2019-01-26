using System;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class TransactionFilterSpecification : BaseSpecification<Transaction>
    {
        public TransactionFilterSpecification(long? id = null,
            long? userId = null,
            TransactionType? transactionType = null,
            TransactionStatus? status = null,
            DateTime? dateFrom = null,
            DateTime? dateTo = null)
            : base(x => (x.Id == id || id == null) && (x.UserId == userId || userId == null) && (x.TransactionType == transactionType || transactionType == null) && (x.Status == status || status == null) && (x.Date >= dateFrom || dateFrom == null) && (x.Date <= dateTo || dateTo == null))
        {
            AddInclude(x => x.User);
            ApplyOrderByDescending(x => x.Date);
        }
    }
}
