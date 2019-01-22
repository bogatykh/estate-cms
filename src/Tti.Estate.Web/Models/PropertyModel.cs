using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class PropertyModel
    {
        /// <summary>
        /// User
        /// </summary>
        [Display(Name = "User")]
        [Required(ErrorMessage = "Required")]
        public long? UserId { get; set; }

        /// <summary>
        /// Transaction type
        /// </summary>
        [Display(Name = "TransactionType")]
        [Required(ErrorMessage = "Required")]
        public TransactionTypeModel? TransactionType { get; set; }
        
        /// <summary>
        /// Property type
        /// </summary>
        [Display(Name = "PropertyType")]
        [Required(ErrorMessage = "Required")]
        public PropertyTypeModel? PropertyType { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Required")]
        public long? Price { get; set; }

        /// <summary>
        /// Area
        /// </summary>
        [Display(Name = "Area")]
        [Required(ErrorMessage = "Required")]
        public decimal? Area { get; set; }

        /// <summary>
        /// House number
        /// </summary>
        [Display(Name = "HouseNumber")]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Flat number
        /// </summary>
        [Display(Name = "FlatNumber")]
        public string FlatNumber { get; set; }

        /// <summary>
        /// Land area
        /// </summary>
        [Display(Name = "LandArea")]
        public decimal? LandArea { get; set; }

        /// <summary>
        /// Floor count
        /// </summary>
        [Display(Name = "FloorCount")]
        public byte? FloorCount { get; set; }

        /// <summary>
        /// Floor
        /// </summary>
        [Display(Name = "Floor")]
        public byte? Floor { get; set; }

        /// <summary>
        /// Room count
        /// </summary>
        [Display(Name = "RoomCount")]
        public byte? RoomCount { get; set; }

        /// <summary>
        /// Is VIP
        /// </summary>
        [Display(Name = "IsVip")]
        public bool IsVip { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        /// <summary>
        /// User collection for drop-down
        /// </summary>
        public IEnumerable<SelectListItem> Users { get; set; }
    }
}
