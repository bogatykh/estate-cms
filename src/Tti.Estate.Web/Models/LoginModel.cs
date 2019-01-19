using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Required")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        [Display(Name = "RememberMe")]
        public bool RememberMe { get; set; }
    }
}
