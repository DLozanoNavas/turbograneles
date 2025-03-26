namespace Italcol.Turbograneles.Domain.Metalteco
{
    public class PartialShipment
    {
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public long ReceiptWeight { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
