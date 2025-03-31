using Italcol.Turbograneles.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Italcol.Turbograneles.Adapters.Data;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Truck> Truck { get;set; }
    public DbSet<Voyage> Voyage { get; set; }
    public DbSet<Driver> Driver { get; set; }
    public DbSet<VoyageStatus> VoyageStatus { get; set; }
    public DbSet<WeighingRecord> WeighingRecord { get; set; }
    public DbSet<TruckAppointment> TruckAppointment { get; set; }
    public DbSet<AppointmentStatus> AppointmentStatus { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<TruckAppointment>()
            .HasOne(a => a.CreatedByUser)
            .WithMany(u => u.CreatedAppointments)
            .HasForeignKey(a => a.CreatedByUserId);

        builder.Entity<TruckAppointment>()
            .HasOne(a => a.UpdatedByUser)
            .WithMany(u => u.UpdatedAppointments)
            .HasForeignKey(a => a.UpdatedByUserId);

        builder.Entity<Voyage>()
            .HasOne(v => v.CreatedByUser)
            .WithMany(u => u.CreatedVoyages)
            .HasForeignKey(a => a.CreatedByUserId);

        builder.Entity<Voyage>()
            .HasOne(v => v.UpdatedByUser)
            .WithMany(u => u.UpdatedVoyages)
            .HasForeignKey(a => a.UpdatedByUserId);
    }
}