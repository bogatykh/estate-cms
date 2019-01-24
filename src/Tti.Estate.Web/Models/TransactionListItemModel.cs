using System;
using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class TransactionListItemModel
    {
        public long Id { get; set; }

        public TransactionTypeModel TransactionType { get; set; }

        public TransactionStatusModel Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public decimal CompanyPercent { get; set; }

        public decimal CompanyAmount
        {
            get
            {
                return Amount * (CompanyPercent / 100);
            }
        }

        public decimal UserPercent { get; set; }

        public decimal UserAmount
        {
            get
            {
                return Amount * (UserPercent / 100);
            }
        }
    }
}
