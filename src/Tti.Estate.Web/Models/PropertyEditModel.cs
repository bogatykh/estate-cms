namespace Tti.Estate.Web.Models
{
    public class PropertyEditModel : PropertyModel
    {
        public long Id { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
