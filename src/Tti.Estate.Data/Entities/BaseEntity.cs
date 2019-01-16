namespace Tti.Estate.Data.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
        }

        public long Id { get; protected set; }
    }
}
