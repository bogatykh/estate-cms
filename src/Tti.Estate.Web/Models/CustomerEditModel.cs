namespace Tti.Estate.Web.Models
{
    public class CustomerEditModel : CustomerModel
    {
        public long Id { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
