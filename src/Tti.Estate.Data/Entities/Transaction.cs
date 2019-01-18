using System;
using System.Collections.Generic;

namespace Tti.Estate.Data.Entities
{
    public class Transaction : BaseEntity
    {
        public long UserId { get; set; }

        public User User { get; set; }

        public TransactionType TransactionType { get; set; }

        public TransactionStatus Status { get; set; }

        public Property Property { get; set; }

        public Customer Customer { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public decimal CompanyPercent { get; set; }

        public decimal UserPercent { get; set; }

        public string Description { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
