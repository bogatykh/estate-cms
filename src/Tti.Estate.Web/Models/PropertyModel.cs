using Microsoft.AspNetCore.Mvc.Rendering;
using System;
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

        [Display(Name = "User")]
        public UserItemModel User { get; set; }

        [Display(Name = "Status")]
        public PropertyStatusModel Status { get; set; }

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
        public decimal? Price { get; set; }

        /// <summary>
        /// Area
        /// </summary>
        [Display(Name = "Area")]
        [Required(ErrorMessage = "Required")]
        public decimal? Area { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [Display(Name = "Region")]
        [Required(ErrorMessage = "Required")]
        public long? RegionId { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        [Display(Name = "Street")]
        public string Street { get; set; }

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
        /// Is restricted availability
        /// </summary>
        [Display(Name = "IsRestricted")]
        public bool IsRestricted { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [Display(Name = "Created")]
        public DateTime Created { get; set; }

        [Display(Name = "Modified")]
        public DateTime Modified { get; set; }

        /// <summary>
        /// Region collection for drop-down
        /// </summary>
        public IEnumerable<SelectListItem> Regions { get; set; }

        /// <summary>
        /// User collection for drop-down
        /// </summary>
        public IEnumerable<SelectListItem> Users { get; set; }
    }
}
