using System;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class TransactionFilterPaginatedSpecification : TransactionFilterSpecification
    {
        public TransactionFilterPaginatedSpecification(int skip, int take,
            long? id = null,
            long? userId = null,
            TransactionType? transactionType = null,
            TransactionStatus? status = null,
            DateTime? dateFrom = null,
            DateTime? dateTo = null)
            : base(userId: userId, transactionType: transactionType, status: status, dateFrom: dateFrom, dateTo: dateTo)
        {
            ApplyPaging(skip, take);
        }
    }
}
