namespace Italcol.Turbograneles.Domain.Metalteco
{
    public class Truck
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Reference { get; set; }
        public int SerialNumber { get; set; }
        public decimal Weight { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? MaterialId { get; set; }
        public bool DirectDispatch { get; set; }
    }

}
