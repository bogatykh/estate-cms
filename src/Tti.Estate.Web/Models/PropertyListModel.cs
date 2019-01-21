using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Tti.Estate.Web.Models
{
    public class PropertyListModel
    {
        public PropertyListCriteriaModel Criteria { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }

        public PagedResultModel<PropertyListItemModel> Properties { get; set; }
    }
}
