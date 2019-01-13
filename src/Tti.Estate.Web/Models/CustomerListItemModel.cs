using System;
using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class CustomerListItemModel
    {
        public long Id { get; set; }
        
        public string FullName { get; set; }
        
        public string User { get; set; }

        public DateTime Modified { get; set; }
    }
}
