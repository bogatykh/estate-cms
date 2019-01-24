using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Tti.Estate.Web.Models
{
    public class TransactionListModel
    {
        public TransactionListCriteriaModel Criteria { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? TotalUserAmount { get; set; }

        public decimal? TotalCompanyAmount { get; set; }

        public PagedResultModel<TransactionListItemModel> Transactions { get; set; }
    }
}