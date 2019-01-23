using System;

namespace Tti.Estate.Web.Models
{
    public class CommentListItemModel
    {
        public long Id { get; set; }

        public string Text { get; set; }

        public string User { get; set; }

        public DateTime Created { get; set; }
    }
}
