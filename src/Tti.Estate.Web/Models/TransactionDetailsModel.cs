using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class TransactionDetailsModel : TransactionEditModel
    {
        [Display(Name = "Status")]
        public TransactionStatusModel Status { get; set; }
    }
}
