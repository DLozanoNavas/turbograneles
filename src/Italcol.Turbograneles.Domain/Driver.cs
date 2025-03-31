namespace Italcol.Turbograneles.Domain
{
    public class Driver
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<TruckAppointment> Appointments { get; set; }
    }
}
