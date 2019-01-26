using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Tti.Estate.Web.Models
{
    public class CustomerListModel
    {
        public CustomerListCriteriaModel Criteria { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }

        public PagedResultModel<CustomerListItemModel> Customers { get; set; }
    }
}
