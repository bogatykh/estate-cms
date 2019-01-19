using System.Collections.Generic;

namespace Tti.Estate.Data.Entities
{
    public class User : BaseEntity
    {
        public UserRole Role { get; set; }

        public UserStatus Status { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Telephone { get; set; }
    }
}
