using Italcol.Turbograneles.Domain.Metalteco;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Italcol.Turbograneles.Adapters.Data;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

    }

    public DbSet<Truck> Trucks { get; set; }
    public DbSet<Vessel> Vessels { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<PartialShipment> PartialShipments { get; set; }
    public DbSet<WeighingRecord> WeighingRecords { get; set; }
}