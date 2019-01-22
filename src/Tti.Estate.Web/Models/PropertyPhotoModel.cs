using System;

namespace Tti.Estate.Web.Models
{
    public class PropertyPhotoModel
    {
        public long Id { get; set; }

        public bool IsDefault { get; set; }

        public Guid ExternalId { get; set; }
    }
}
