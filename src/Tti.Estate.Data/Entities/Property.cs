using System;
using System.Collections.Generic;

namespace Tti.Estate.Data.Entities
{
    public class Property : BaseEntity
    {
        public Property()
        {
            Created = Modified = DateTime.UtcNow;
        }

        public long UserId { get; set; }

        public User User { get; set; }

        public PropertyType PropertyType { get; set; }

        public TransactionType TransactionType { get; set; }

        public PropertyStatus Status { get; set; }

        public long Price { get; set; }

        public PriceType? PriceType { get; set; }

        public long RegionId { get; set; }
        public Region Region { get; set; }

        public long StreetId { get; set; }
        public Street Street { get; set; }

        public string HouseNumber { get; set; }

        public string FlatNumber { get; set; }

        public decimal Area { get; set; }

        public decimal? LandArea { get; set; }

        public byte? FloorCount { get; set; }

        public byte? Floor { get; set; }

        public byte? RoomCount { get; set; }

        public bool IsVip { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Contact> Contacts { get; set; }

        public List<PropertyPhoto> Photos { get; set; }
    }
}
