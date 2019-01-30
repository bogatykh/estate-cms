using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class ContactModel
    {
        public long? CustomerId { get; set; }

        public long? PropertyId { get; set; }
        
        [Display(Name = "FirstName")]
        [StringLength(50)]
        [Required(ErrorMessage = "Required")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Telephone")]
        [StringLength(50)]
        [Required(ErrorMessage = "Required")]
        public string Telephone { get; set; }

        [Display(Name = "Email")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
