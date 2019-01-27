using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class TransactionModel
    {
        [Display(Name = "User")]
        [Required(ErrorMessage = "Required")]
        public long? UserId { get; set; }

        [Display(Name = "User")]
        public UserItemModel User { get; set; }

        [Display(Name = "Status")]
        public TransactionStatusModel Status { get; set; }
        
        [Display(Name = "TransactionType")]
        [Required(ErrorMessage = "Required")]
        public TransactionTypeModel? TransactionType { get; set; }
        
        [Display(Name = "Property")]
        [Required(ErrorMessage = "Required")]
        public long? PropertyId { get; set; }

        [Display(Name = "Customer")]
        [Required(ErrorMessage = "Required")]
        public long? CustomerId { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public DateTime? Date { get; set; }

        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Required")]
        public decimal? Amount { get; set; }

        [Display(Name = "CompanyPercent")]
        [Required(ErrorMessage = "Required")]
        [Range(1, 100)]
        public byte? CompanyPercent { get; set; }

        [Display(Name = "UserPercent")]
        [Required(ErrorMessage = "Required")]
        [Range(1, 100)]
        public byte? UserPercent { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Created")]
        public DateTime Created { get; set; }

        [Display(Name = "Modified")]
        public DateTime Modified { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }
    }
}
