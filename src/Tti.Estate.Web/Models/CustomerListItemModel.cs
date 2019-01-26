using System;

namespace Tti.Estate.Web.Models
{
    public class CustomerListItemModel
    {
        public long Id { get; set; }
        
        public ContactItemModel Contact { get; set; }
        
        public UserItemModel User { get; set; }

        public DateTime Modified { get; set; }
    }
}
