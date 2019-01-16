namespace Tti.Estate.Web.Models
{
    public class UserEditModel : UserModel
    {
        public long Id { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
