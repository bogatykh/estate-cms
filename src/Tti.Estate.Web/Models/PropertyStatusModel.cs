using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public enum PropertyStatusModel
    {
        [Display(Name = "Active")]
        Active = 0,

        [Display(Name = "Reserved")]
        Reserved,

        [Display(Name = "Realized")]
        Realized,

        [Display(Name = "Transaction")]
        Transaction,

        [Display(Name = "Deleted")]
        Deleted
    }
}
