using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class ChangePasswordModel
    {
        public long UserId { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "PasswordRequired")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "ConfirmPasswordRequired")]
        [Compare(nameof(Password), ErrorMessage = "PasswordsNotEqual")]
        [Display(Name = "ConfirmPassword")]
        public string ConfirmPassword { get; set; }
    }
}
