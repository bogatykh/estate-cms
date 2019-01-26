using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class CustomerListCriteriaModel
    {
        [Display(Name = "User")]
        public long? UserId { get; set; }

        [Display(Name = "Id")]
        public long? Id { get; set; }

        [Display(Name = "Term")]
        public string Term { get; set; }
    }
}
