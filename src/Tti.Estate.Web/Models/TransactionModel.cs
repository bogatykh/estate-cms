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

        [Display(Name = "TransactionType")]
        [Required(ErrorMessage = "Required")]
        public TransactionTypeModel? TransactionType { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public DateTime? Date { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }
    }
}
