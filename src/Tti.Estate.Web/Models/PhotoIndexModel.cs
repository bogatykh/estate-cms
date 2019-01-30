using System;
using System.Collections.Generic;

namespace Tti.Estate.Web.Models
{
    public class PhotoIndexModel
    {
        public long PropertyId { get; set; }

        public Uri StorageUri { get; set; }

        public IEnumerable<PhotoModel> Photos { get; set; }
    }
}
