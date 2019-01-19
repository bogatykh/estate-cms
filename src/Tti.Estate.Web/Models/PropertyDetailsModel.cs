﻿using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class PropertyDetailsModel : PropertyEditModel
    {
        [Display(Name = "Status")]
        public PropertyStatusModel Status { get; set; }
    }
}