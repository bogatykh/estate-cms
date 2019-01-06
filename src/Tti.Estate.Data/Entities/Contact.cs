namespace Tti.Estate.Data.Entities
{
    public class Contact : BaseEntity
    {
        public Property Property { get; set; }

        public Customer Customer { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }
    }
}
