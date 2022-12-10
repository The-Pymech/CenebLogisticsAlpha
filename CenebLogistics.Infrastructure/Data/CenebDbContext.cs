

using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.DataModels.AuthData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CenebLogistics.Infrastructure.Data
{
  public class CenebDbContext : IdentityDbContext<DataUser>
  {
    public CenebDbContext(DbContextOptions<CenebDbContext> options)
        : base(options)
    {
    }

    public DbSet<Crew> Crews { get; set; }
    public DbSet<Cylinder> Cylinders { get; set; }
    public DbSet<CylinderContent> CylinderContents { get; set; }
    public DbSet<CylinderSize> CylinderSizes { get; set; }
    public DbSet<CylinderType> CylinderTypes { get; set; }
    public DbSet<CylinderVersion> CylinderVersions { get; set; }
    public DbSet<HistoryCylinder> HistoryCylinders { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Staff> Staff { get; set; }
    public DbSet<Transit> Transits { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
  }
}