using System;

namespace Tti.Estate.Web.Models
{
    public class TransactionListItemModel
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }
    }
}
