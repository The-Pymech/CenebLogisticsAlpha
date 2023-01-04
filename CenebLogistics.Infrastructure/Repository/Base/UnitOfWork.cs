using CenebLogistics.Application.Repository;
using CenebLogistics.Application.Repository.Base;
using CenebLogistics.Infrastructure.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Infrastructure.Repository.Base
{
  public class UnitOfWork : IUnitOfWork, IDisposable
  {

    private readonly CenebDbContext _dbContext;
    private readonly ILogger _logger;


    public UnitOfWork(CenebDbContext cenebDbContext, ILoggerFactory loggerFactory)
    {
      _dbContext = cenebDbContext;
      _logger = loggerFactory.CreateLogger("logs");

      UnitCrew = new CrewRepository(_dbContext, _logger);
    }



    public ICrewRepository UnitCrew { get; private set; }

    public ICylinderRepository Unitcylinder { get; private set; }

    public ICylinderSizeRepository UnitcylinderSize { get; private set; }

    public ICylinderTypeRepository UnitcylinderType { get; private set; }

    public ICylinderContentRepository UnitcylinderContent { get; private set; }
    public ICylinderVersionRepository UnitcylinderVersion { get; private set; }

    public IDataUserRepository UnitdataUser { get; private set; }

    public IHistoryCylinderRepository UnithistoryCylinder { get; private set; }

    public ILocationRepository Unitlocation { get; private set; }

    public IStaffRepository Unitstaff { get; private set; }

    public ITransitRepository Unittransit { get; private set; }

    public IVehicleRepository Unitvehicle { get; private set; }

    public async Task CompleteAsync()
    {
      await _dbContext.SaveChangesAsync();
    }

    public async Task DisposeAsync()
    {
      await _dbContext.DisposeAsync();
    }

    public void Dispose()
    {
      _dbContext.Dispose();
    }
  }
}
