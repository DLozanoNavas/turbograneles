namespace Italcol.Turbograneles.Domain
{
    public class Voyage 
    {
        public string VoyageId { get; set; }
        public string VesselName { get; set; }
        public DateTime Eta { get; set; }
        public DateTime Etd { get; set; }
        public string BlNumber { get; set; }
        public string Customer { get; set; }
        public string Product { get; set; }
        public long WeightBlStart { get; set; }
        public long WeightBlEnd { get; set; }
        public string StatusId { get; set; }
        public VoyageStatus Status { get; set; }
        public List<WeighingRecord> WeighingRecords { get; set; }
        public string CreatedByUserId { get; set; }
        public ApplicationUser CreatedByUser { get; set; }
        public string UpdatedByUserId { get; set; }
        public ApplicationUser UpdatedByUser { get; set; }
    }
}
