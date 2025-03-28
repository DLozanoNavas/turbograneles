using System.Net.Sockets;

namespace Italcol.Turbograneles.Domain
{
    public class TruckAppointment
    {
        public string BlNumber { get; set; }
        public string ProductId { get; set; }
        public long MaxWeightPermitted { get; set; }
        public long WeightRequired { get;set; }
        public long ArriveWeight { get; set; }
        public long CargoWeight { get; set; }
        public long TruckGrossWeight { get; set; }
        public long WeightingBridgeId { get;set; }
        public int DestinationCode { get; set; }
        public string TransportId { get; set; }
        public int WeightBridgeId { get; set; }
        public int TruckTransactionId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public DateTime ArriveDateTime { get; set; }
        public DateTime DepartureDateTime { get; set; }

        // Foreign Relationships
        public string StatusId { get; set; }
        public AppointmentStatus Status { get; set; }
        public string DriverId { get; set; }
        public Driver Driver { get; set; }
        public string TruckId { get; set; }
        public Truck Truck { get; set; }
        public string VoyageId { get; set; }
        public Voyage Voyage { get; set; }
        
        //
        public string CreatedByUserId { get; set; }
        public ApplicationUser CreatedByUser { get; set; }
        public string UpdatedByUserId { get; set; }
        public ApplicationUser UpdatedByUser { get; set; }
    }
}
