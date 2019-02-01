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

        /// <summary>
        /// County
        /// </summary>
        [Display(Name = "County")]
        public long? CountyId { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [Display(Name = "City")]
        public long? CityId { get; set; }

        [Display(Name = "PriceFrom")]
        public decimal? PriceFrom { get; set; }
        
        [Display(Name = "PriceTo")]
        public decimal? PriceTo { get; set; }

        [Display(Name = "Code")]
        public long? Code { get; set; }

        [Display(Name = "Telephone")]
        public string Telephone { get; set; }
    }
}
