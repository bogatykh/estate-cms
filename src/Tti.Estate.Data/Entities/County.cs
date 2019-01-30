using System.Collections.Generic;

namespace Tti.Estate.Data.Entities
{
    public class County : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public List<City> Cities { get; set; }
    }
}
