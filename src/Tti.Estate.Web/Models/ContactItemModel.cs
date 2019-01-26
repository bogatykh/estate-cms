namespace Tti.Estate.Web.Models
{
    public class ContactItemModel : ContactModel
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
