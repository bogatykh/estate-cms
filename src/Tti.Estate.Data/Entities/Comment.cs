using System;

namespace Tti.Estate.Data.Entities
{
    public class Comment : BaseEntity
    {
        public Comment()
        {
            Created = DateTime.UtcNow;
        }

        public long UserId { get; set; }
        public User User { get; set; }

        public long? PropertyId { get; set; }
        public Property Property { get; set; }

        public long? CustomerId { get; set; }
        public Customer Customer { get; set; }

        public long? TransactionId { get; set; }
        public Transaction Transaction { get; set; }

        public string Text { get; set; }

        public DateTime Created { get; private set; }
    }
}
