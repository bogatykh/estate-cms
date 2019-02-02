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

        public decimal Price { get; set; }

        public bool HasVat { get; set; }

        public long CountyId { get; set; }
        public County County { get; set; }

        public long CityId { get; set; }
        public City City { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string ApartmentNumber { get; set; }

        public string CadastralNumber { get; set; }

        public decimal Area { get; set; }

        public decimal? LandArea { get; set; }

        public byte? FloorCount { get; set; }

        public byte? Floor { get; set; }

        public byte? RoomCount { get; set; }

        public bool IsRestricted { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; internal set; }

        public DateTime Modified { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Contact> Contacts { get; set; }

        public List<Photo> Photos { get; set; }
    }
}
