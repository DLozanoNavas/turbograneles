using System.ComponentModel.DataAnnotations;

namespace Italcol.Turbograneles.Domain
{
    public class Truck
    {
        [Key]
        public string Plate { get; set; }
        public List<TruckAppointment> Appointments { get; set; }
    }
}

