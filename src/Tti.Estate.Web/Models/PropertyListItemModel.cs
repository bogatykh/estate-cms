using System;

namespace Tti.Estate.Web.Models
{
    public class PropertyListItemModel
    {
        public long Id { get; set; }

        public PropertyTypeModel PropertyType { get; set; }

        public PropertyStatusModel Status { get; set; }

        public decimal Price { get; set; }

        public decimal Area { get; set; }

        public DateTime Modified { get; set; }
    }
}
