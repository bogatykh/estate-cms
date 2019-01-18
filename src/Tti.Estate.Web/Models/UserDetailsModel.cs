using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class UserDetailsModel : UserEditModel
    {
        [Display(Name = "Status")]
        public UserStatusModel Status { get; set; }
    }
}
