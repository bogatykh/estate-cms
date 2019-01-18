using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public enum TransactionTypeModel
    {
        [Display(Name = "Trade")]
        Trade = 0,

        [Display(Name = "Rent")]
        Rent
    }
}
