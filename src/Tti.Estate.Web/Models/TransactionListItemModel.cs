using System;
using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class TransactionListItemModel
    {
        public long Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }
    }
}
