using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class CustomerListCriteriaModel
    {
        [Display(Name = "User")]
        public long? UserId { get; set; }
    }
}
