using System;
using System.Collections.Generic;

namespace Tti.Estate.Data.Entities
{
    public class Transaction : BaseEntity
    {
        public Transaction()
        {
            Created = Modified = DateTime.UtcNow;
        }

        public long UserId { get; set; }

        public User User { get; set; }

        public TransactionType TransactionType { get; set; }

        public TransactionStatus Status { get; set; }

        public long PropertyId { get; set; }
        public Property Property { get; set; }

        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public byte CompanyPercent { get; set; }

        public byte UserPercent { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
