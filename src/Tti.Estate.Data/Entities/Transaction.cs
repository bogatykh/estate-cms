using System;
using System.Collections.Generic;

namespace Tti.Estate.Data.Entities
{
    public class Transaction : BaseEntity
    {
        public User User { get; set; }

        public Property Property { get; set; }

        public Customer Customer { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
