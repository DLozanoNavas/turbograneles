namespace Italcol.Turbograneles.Domain
{
    public class AppointmentStatus
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreatedByUserId { get; set; }
        public ApplicationUser CreatedByUser { get; set; }
    }
}
