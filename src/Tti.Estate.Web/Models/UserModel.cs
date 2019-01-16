using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class UserModel
    {
        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Required")]
        [StringLength(256)]
        public string UserName { get; set; }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "Required")]
        public UserRoleModel? Role { get; set; }

        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Telephone")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        public string Telephone { get; set; }
    }
}
