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

      UnitCrewRepository = new CrewRepository(_dbContext,_logger);
    }



    public ICrewRepository UnitCrewRepository { get; private set; }

    public ICylinderRepository UnitcylinderRepository { get; private set; }

    public ICylinderSizeRepository UnitcylinderSizeRepository { get; private set; }

    public CylinderTypeRepository UnitcylinderTypeRepository { get; private set; }

    public ICylinderVersionRepository UnitcylinderVersionRepository { get; private set; }

    public IDataUserRepository UnitdataUserRepository { get; private set; }

    public IHistoryCylinderRepository UnithistoryCylinderRepository { get; private set; }

    public ILocationRepository UnitlocationRepository { get; private set; }

    public IStaffRepository UnitstaffRepository { get; private set; }

    public ITransitRepository UnittransitRepository { get; private set; }

    public IVehicleRepository UnitvehicleRepository { get; private set; }

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
