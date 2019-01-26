using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class PropertyListCriteriaModel
    {
        [Display(Name = "User")]
        public long? UserId { get; set; }

        [Display(Name = "PropertyType")]
        public PropertyTypeModel? PropertyType { get; set; }

        [Display(Name = "Status")]
        public PropertyStatusModel? Status { get; set; }

        [Display(Name = "TransactionType")]
        public TransactionTypeModel? TransactionType { get; set; }
        
        [Display(Name = "PriceFrom")]
        public long? PriceFrom { get; set; }
        
        [Display(Name = "PriceTo")]
        public long? PriceTo { get; set; }
    }
}
