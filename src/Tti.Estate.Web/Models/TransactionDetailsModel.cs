using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class TransactionDetailsModel : TransactionEditModel
    {
        public List<CommentListItemModel> Comments { get; set; }
    }
}
