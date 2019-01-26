using System.Collections.Generic;

namespace Tti.Estate.Web.Models
{
    public class PropertyDetailsModel : PropertyEditModel
    {
        public List<ContactListItemModel> Contacts { get; set; }

        public List<CommentListItemModel> Comments { get; set; }
    }
}
