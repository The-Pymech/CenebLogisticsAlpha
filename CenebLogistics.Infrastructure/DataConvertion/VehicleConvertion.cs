using CenebLogistics.Application.DataConvertion;
using CenebLogistics.Application.Repository.Base;
using CenebLogistics.Application.Services.CenebTask;
using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.ViewModels.DisplayModels;
using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Infrastructure.DataConvertion
{
  public class VehicleConvertion : IVehicleConvertion
  {
    private IUnitOfWork _unitOfWork;
    private ICenebConversions _conversions;
    public VehicleConvertion(IUnitOfWork unitOfWork, ICenebConversions conversions)
    {
      _unitOfWork = unitOfWork;
      _conversions = conversions;
    }


    public async Task<VehicleListModel> VehicleToVehicleListModel(Vehicle input)
    {
      var createdBy = await _unitOfWork.UnitdataUser.GetSingle(input.CreatedById);
      var updatedBy = await _unitOfWork.UnitdataUser.GetSingle(input.UpdatedById);
     // var driver = await _unitOfWork.Unitstaff.GetSingle(input.DriverId);
      var output = new VehicleListModel()
      {
        Id = input.Id,
        isDeleted = input.isDeleted,
        CreatedByFullName = _conversions.FullNameFromuser(createdBy),
        UpdatedByFullName = _conversions.FullNameFromuser(updatedBy),
        CreatedOn = _conversions.DateTimeToString(input.CreatedOn),
        LastUpdatedOn = _conversions.DateTimeToString(input.LastUpdatedOn),
        Description = input.Description,
        DriverId = input.DriverId,
        Name = input.Name,
        PlateNumber = input.PlateNumber,
        VehicleNumber = input.VehicleNumber
      };
      return output;
    }

    public async Task<VehicleOverview> VehicleToVehicleOverview(Vehicle input)
    {
       var driver = await _unitOfWork.Unitstaff.GetSingle(input.DriverId);
      var allTransits = await _unitOfWork.Unittransit.GetAll();
      var lastTransit = allTransits.Where(m => m.VehicleId == input.Id)
        .OrderByDescending(m => m.Id).FirstOrDefault();
      var output = new VehicleOverview()
      {
        DriverName = driver.FullName,
        LastTransitDate = _conversions.DateTimeToString(lastTransit.Date),
        VehicleName = input.Name,
        VehileId = input.Id
      };
      return output;
    }
  }
}
