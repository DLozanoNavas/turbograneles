using Microsoft.AspNetCore.Identity;

namespace Italcol.Turbograneles.Domain;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public List<AppointmentStatus> CreatedAppointmentStatuses { get; set; }

    public List<TruckAppointment> CreatedAppointments { get; set; }
    public List<TruckAppointment> UpdatedAppointments { get; set; }
    public List<Voyage> CreatedVoyages { get; set; }
    public List<Voyage> UpdatedVoyages { get; set; }
    public List<VoyageStatus> CreatedVoyagesStatus { get; set; }
    public List<WeighingRecord> CreatedWeighingRecords { get; set; }
}

