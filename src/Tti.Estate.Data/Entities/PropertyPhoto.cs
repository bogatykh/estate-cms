using System;

namespace Tti.Estate.Data.Entities
{
    public class PropertyPhoto : BaseEntity
    {
        public long PropertyId { get; set; }
        public Property Property { get; set; }

        public bool IsDefault { get; set; }

        public Guid ExternalId { get; set; }
    }
}
