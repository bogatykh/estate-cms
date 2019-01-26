using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class PropertyListCriteriaModel
    {
        [Display(Name = "User")]
        public long? UserId { get; set; }
    }
}
