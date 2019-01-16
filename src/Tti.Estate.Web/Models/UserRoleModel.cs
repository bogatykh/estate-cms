using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public enum UserRoleModel
    {
        [Display(Name = "Agent")]
        Agent = 0,

        [Display(Name = "Manager")]
        Manager
    }
}
