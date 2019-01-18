using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public enum TransactionStatusModel
    {
        [Display(Name = "Draft")]
        Draft = 0,

        [Display(Name = "Approving")]
        Approving,

        [Display(Name = "Approved")]
        Approved
    }
}
