using System;
using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class TransactionListCriteriaModel
    {
        [Display(Name = "User")]
        public long? UserId { get; set; }

        [Display(Name = "Status")]
        public TransactionStatusModel? Status { get; set; }

        [Display(Name = "TransactionType")]
        public TransactionTypeModel? TransactionType { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "DateFrom")]
        public DateTime? DateFrom { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "DateTo")]
        public DateTime? DateTo { get; set; }
    }
}
