using Newtonsoft.Json;

namespace Tti.Estate.Web.Models
{
    public class DataTableRequestModel
    {
        [JsonProperty("draw")]
        public int DrawCounter { get; set; }

        [JsonProperty("start")]
        public int Offset { get; set; }

        [JsonProperty("length")]
        public int PageSize { get; set; }
    }
}
