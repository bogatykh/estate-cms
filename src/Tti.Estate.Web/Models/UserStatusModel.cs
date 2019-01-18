using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public enum UserStatusModel
    {
        [Display(Name = "Active")]
        Active = 0,

        [Display(Name = "Blocked")]
        Blocked,

        [Display(Name = "Deleted")]
        Deleted
    }
}
