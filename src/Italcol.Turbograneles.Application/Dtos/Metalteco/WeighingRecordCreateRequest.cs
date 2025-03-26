namespace Italcol.Turbograneles.Application.Dtos.Metalteco
{

    public class WeighingRecordCreateRequest
    {
        public int TransactionId { get; set; }
        public int ScaleId { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal TargetWeight { get; set; }
        public decimal ActualWeight { get; set; }
    }

}
