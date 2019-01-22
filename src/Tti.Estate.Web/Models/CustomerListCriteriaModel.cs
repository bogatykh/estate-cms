using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class CustomerListCriteriaModel
    {
        [Display(Name = "UserId")]
        public long? UserId { get; set; }
    }
}
