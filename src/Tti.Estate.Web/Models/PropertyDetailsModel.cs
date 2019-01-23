using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class PropertyDetailsModel : PropertyEditModel
    {
        [Display(Name = "Status")]
        public PropertyStatusModel Status { get; set; }

        public List<ContactListItemModel> Contacts { get; set; }

        public List<CommentListItemModel> Comments { get; set; }
    }
}
