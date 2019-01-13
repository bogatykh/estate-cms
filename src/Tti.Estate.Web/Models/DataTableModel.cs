using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tti.Estate.Web.Models
{
    public class DataTableModel
    {
        [JsonProperty("draw")]
        public int DrawCounter { get; set; }

        [JsonProperty("recordsFiltered")]
        public int TotalItems { get; set; }

        [JsonProperty("recordsTotal")]
        public int FilteredItems { get; set; }
    }

    public class DataTableModel<TItemModel> : DataTableModel
    {
        [JsonProperty("data")]
        public IEnumerable<TItemModel> Items { get; set; }
    }
}
