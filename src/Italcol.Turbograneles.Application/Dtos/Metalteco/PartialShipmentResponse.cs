namespace Italcol.Turbograneles.Application.Dtos.Metalteco
{
    public class PartialShipmentResponse
    {
        public string Reference { get; set; }
        public int Consecutive { get; set; }
        public int TransactionId { get; set; }
        public int ScaleId { get; set; }
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public decimal Weight { get; set; }
        public DateTime ShipmentDate { get; set; }
    }
}
