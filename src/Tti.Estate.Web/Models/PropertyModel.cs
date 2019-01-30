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
        /// VAT included in price
        /// </summary>
        [Display(Name = "HasVat")]
        public bool HasVat { get; set; }

        /// <summary>
        /// Area
        /// </summary>
        [Display(Name = "Area")]
        [Required(ErrorMessage = "Required")]
        public decimal? Area { get; set; }

        /// <summary>
        /// County
        /// </summary>
        [Display(Name = "County")]
        [Required(ErrorMessage = "Required")]
        public long? CountyId { get; set; }

        [Display(Name = "County")]
        public CountyItemModel County { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [Display(Name = "City")]
        [Required(ErrorMessage = "Required")]
        public long? CityId { get; set; }

        [Display(Name = "City")]
        public CityItemModel City { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        [StringLength(64)]
        [Display(Name = "Street")]
        public string Street { get; set; }

        /// <summary>
        /// House number
        /// </summary>
        [StringLength(8)]
        [Display(Name = "HouseNumber")]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Apartment number
        /// </summary>
        [StringLength(8)]
        [Display(Name = "ApartmentNumber")]
        public string ApartmentNumber { get; set; }

        /// <summary>
        /// Cadastral number
        /// </summary>
        [StringLength(128)]
        [Display(Name = "CadastralNumber")]
        public string CadastralNumber { get; set; }

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
        /// County collection for drop-down
        /// </summary>
        public IEnumerable<SelectListItem> Counties { get; set; }

        /// <summary>
        /// City collection for drop-down
        /// </summary>
        public IEnumerable<SelectListItem> Cities { get; set; }

        /// <summary>
        /// User collection for drop-down
        /// </summary>
        public IEnumerable<SelectListItem> Users { get; set; }
    }
}
