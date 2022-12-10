using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Repository.Base
{
  public interface IUnitOfWork
  {
    ICrewRepository UnitCrewRepository { get; }
    ICylinderRepository UnitcylinderRepository { get; }

    ICylinderSizeRepository UnitcylinderSizeRepository { get; }
    ICylinderTypeRepository UnitcylinderTypeRepository { get; }
    ICylinderVersionRepository UnitcylinderVersionRepository { get; }

    IDataUserRepository UnitdataUserRepository { get; }

    IHistoryCylinderRepository UnithistoryCylinderRepository { get; }
    ILocationRepository UnitlocationRepository { get; }
    IStaffRepository UnitstaffRepository { get; }
    ITransitRepository UnittransitRepository { get; }

    IVehicleRepository UnitvehicleRepository { get; }

    Task CompleteAsync();

  }
}
