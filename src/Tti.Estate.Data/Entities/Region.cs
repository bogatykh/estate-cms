using System.Collections.Generic;

namespace Tti.Estate.Data.Entities
{
    public class Region : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public Region Parent { get; set; }

        public List<Region> Childrens { get; set; }
    }
}
