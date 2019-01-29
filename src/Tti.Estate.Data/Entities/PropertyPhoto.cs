using System;

namespace Tti.Estate.Data.Entities
{
    public class PropertyPhoto : BaseEntity
    {
        public PropertyPhoto()
        {
            ExternalId = Guid.NewGuid();
        }

        public long PropertyId { get; set; }
        public Property Property { get; set; }

        public bool IsDefault { get; set; }

        public Guid ExternalId { get; private set; }
    }
}
