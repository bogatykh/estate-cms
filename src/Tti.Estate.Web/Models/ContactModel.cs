using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class ContactModel
    {
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "Telephone")]
        public string Telephone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
