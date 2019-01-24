namespace Tti.Estate.Data.Entities
{
    public class Contact : BaseEntity
    {
        public long? PropertyId { get; set; }
        public Property Property { get; set; }

        public long? CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }
    }
}
