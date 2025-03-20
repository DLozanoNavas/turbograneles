namespace Italcol.Turbograneles.Domain.Metalteco
{

    public class WeighingRecord
    {
        public int TransactionId { get; set; }
        public int ScaleId { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal TargetWeight { get; set; }
        public decimal ActualWeight { get; set; }
    }

}
