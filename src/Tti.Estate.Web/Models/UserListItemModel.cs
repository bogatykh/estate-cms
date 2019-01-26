namespace Tti.Estate.Web.Models
{
    public class UserListItemModel
    {
        public long Id { get; set; }

        public UserStatusModel Status { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Telephone { get; set; }
    }
}
