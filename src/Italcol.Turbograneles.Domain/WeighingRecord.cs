namespace Italcol.Turbograneles.Domain
{
    public class WeighingRecord
    {
        /*
           idTransaction (int 5)
         */
        public string Id { get; set; }
        public int WeighingPitId { get; set; }
        public long Weight { get; set; }
        public string VoyageId { get; set; }
        public Voyage Voyage { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public string CreatedByUserId { get; set; }
        public ApplicationUser CreatedByUser { get; set; }
    }
}
