using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class CustomerDetailsModel : CustomerEditModel
    {
        public List<ContactListItemModel> Contacts { get; set; }

        public List<CommentListItemModel> Comments { get; set; }
    }
}
