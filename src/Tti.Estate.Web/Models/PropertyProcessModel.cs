using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class PropertyProcessModel
    {
        public long PropertyId { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "StatusRequired")]
        public PropertyStatusModel? Status { get; set; }

        [Display(Name = "Comment")]
        public string Comment { get; set; }
    }
}
