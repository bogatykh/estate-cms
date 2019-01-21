using System.Collections.Generic;

namespace Tti.Estate.Web.Models
{
    public class PagedResultModel
    {
        public int PageIndex { get; set; }

        public int TotalPages { get; set; }

        public int TotalItems { get; set; }

        public bool HasPreviousPage
        {
            get
            {
                return PageIndex > 0;
            }
        }

        public bool HasNextPage
        {
            get
            {
                return PageIndex < TotalPages - 1;
            }
        }
    }

    public class PagedResultModel<TListItemModel> : PagedResultModel
        where TListItemModel : class
    {
        public IEnumerable<TListItemModel> Items { get; set; }
    }
}
