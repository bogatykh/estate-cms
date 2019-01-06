namespace Tti.Estate.Data.Entities
{
    public class PropertyPhoto : BaseEntity
    {
        public Property Property { get; set; }

        public bool IsMain { get; set; }
    }
}
