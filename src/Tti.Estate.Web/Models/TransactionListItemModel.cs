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

        public byte CompanyPercent { get; set; }

        public decimal CompanyAmount
        {
            get
            {
                return Math.Round(Amount * CompanyPercent * 0.01m, 2);
            }
        }

        public byte UserPercent { get; set; }

        public decimal UserAmount
        {
            get
            {
                return Math.Round(Amount * UserPercent * 0.01m, 2);
            }
        }
    }
}
