namespace Tti.Estate.Web.Models
{
    public class TransactionEditModel : TransactionModel
    {
        public long Id { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
