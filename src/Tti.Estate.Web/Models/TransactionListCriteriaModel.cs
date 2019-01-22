using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class TransactionListCriteriaModel
    {
        [Display(Name = "UserId")]
        public long? UserId { get; set; }
    }
}
