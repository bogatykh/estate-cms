using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public class CommentModel
    {
        public long? CustomerId { get; set; }

        public long? PropertyId { get; set; }

        public long? TransactionId { get; set; }

        [Display(Name = "Text")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "TextRequired")]
        public string Text { get; set; }
    }
}
