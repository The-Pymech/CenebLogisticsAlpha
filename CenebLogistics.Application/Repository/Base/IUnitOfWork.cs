using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Repository.Base
{
  public interface IUnitOfWork
  {
    ICrewRepository UnitCrew { get; }
    ICylinderRepository Unitcylinder { get; }

    ICylinderSizeRepository UnitcylinderSize { get; }
    ICylinderTypeRepository UnitcylinderType { get; }
    ICylinderVersionRepository UnitcylinderVersion { get; }

    IDataUserRepository UnitdataUser { get; }

    IHistoryCylinderRepository UnithistoryCylinder { get; }
    ILocationRepository Unitlocation { get; }
    IStaffRepository Unitstaff { get; }
    ITransitRepository Unittransit { get; }

    IVehicleRepository Unitvehicle { get; }

    Task CompleteAsync();

  }
}
