using System;
using System.Collections.Generic;

namespace Tti.Estate.Data.Entities
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            Created = Modified = DateTime.UtcNow;
        }

        public long UserId { get; set; }

        public User User { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; internal set; }

        public DateTime Modified { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}
