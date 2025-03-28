namespace Italcol.Turbograneles.Application.Dtos.Metalteco
{
    public class TransactionUpdateRequest
    {
        public int MaterialId { get; set; }
        public string Type { get; set; }
        public string Ref1 { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public string Status { get; set; }
        public int VesselId { get; set; }
        public int Pit { get; set; }
    }
}
