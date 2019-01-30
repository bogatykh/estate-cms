namespace Tti.Estate.Data.Entities
{
    public class City : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public long CountyId { get; set; }
        public County County { get; set; }
    }
}
