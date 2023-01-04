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
  public class TransitConvertion : ITransitConvertion
  {

    private IUnitOfWork _unitOfWork;
    private ICenebConversions _conversions;
    public TransitConvertion(IUnitOfWork unitOfWork, ICenebConversions conversions)
    {
      _unitOfWork = unitOfWork;
      _conversions = conversions;
    }


    public async Task<TransitListModel> TransitToTransitListModel(Transit input)
    {
      var createdBy = await _unitOfWork.UnitdataUser.GetSingle(input.CreatedById);
      var updatedBy = await _unitOfWork.UnitdataUser.GetSingle(input.UpdatedById);
      var fromLocation = await _unitOfWork.Unitlocation.GetSingle(input.FromLocation);
      var toLocation = await _unitOfWork.Unitlocation.GetSingle(input.ToLocation);
      var vehicle = await _unitOfWork.Unitvehicle.GetSingle(input.VehicleId);
      var output = new TransitListModel()
      {
        Id = input.Id,
        isDeleted = input.isDeleted,
        CreatedByFullName = _conversions.FullNameFromuser(createdBy),
        UpdatedByFullName = _conversions.FullNameFromuser(updatedBy),
        CreatedOn = _conversions.DateTimeToString(input.CreatedOn),
        LastUpdatedOn = _conversions.DateTimeToString(input.LastUpdatedOn),
        FromLocation = fromLocation.Id,
        ToLocation = toLocation.Id,
        FromLocatomName = fromLocation.Description,
        ToLocationName = toLocation.Description,
        Description = input.Description,
        Date = _conversions.DateTimeToString(input.Date),
        VehicleId = vehicle.Id,
        VehicleName = vehicle.Name,
      };
      return output;
    }

    public async Task<TransitOverview> TransitToTransitOverview(Transit input)
    {

      var vehicle = await _unitOfWork.Unitvehicle.GetSingle(input.VehicleId);
      var driver = await _unitOfWork.Unitstaff.GetSingle(vehicle.DriverId);
      var fromLocation = await _unitOfWork.Unitlocation.GetSingle(input.FromLocation);
      var toLocation = await _unitOfWork.Unitlocation.GetSingle(input.ToLocation);
      var allCrew = await _unitOfWork.UnitCrew.GetAll();
      var transitCrew = allCrew.Where(m => m.TransitId == input.Id);
      
      var output = new TransitOverview()
      {
        Date = _conversions.DateTimeToString(input.Date),
        Description = input.Description,
        Driver = driver.FullName,
        From = fromLocation.Description,
        To = toLocation.Description,
        NumberOfCrewPersonel = transitCrew.Count(),
        TransitId = input.Id,
        VehicleId = vehicle.Id,
        VehicleName = vehicle.Name
        
      };
      return output;


    }
  }
}
