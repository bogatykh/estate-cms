using System;

namespace Tti.Estate.Data.Entities
{
    public class Comment : BaseEntity
    {
        public Comment()
        {
            Created = DateTime.UtcNow;
        }

        public User User { get; set; }

        public Property Property { get; set; }

        public Customer Customer { get; set; }

        public Transaction Transaction { get; set; }

        public string Text { get; set; }

        public DateTime Created { get; set; }
    }
}
