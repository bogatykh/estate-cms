using System;
using System.Collections.Generic;

namespace Tti.Estate.Web.Models
{
    public class PropertyPhotoIndexModel
    {
        public long PropertyId { get; set; }

        public Uri StorageUri { get; set; }

        public IEnumerable<PropertyPhotoModel> Photos { get; set; }
    }
}
