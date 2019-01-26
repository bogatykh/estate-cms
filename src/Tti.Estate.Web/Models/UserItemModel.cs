namespace Tti.Estate.Web.Models
{
    public class UserItemModel : UserModel
    {
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
