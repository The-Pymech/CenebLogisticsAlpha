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
  public class LocationConvertion : ILocationConvertion
  {
    private IUnitOfWork _unitOfWork;
    private ICenebConversions _conversions;
    public LocationConvertion(IUnitOfWork unitOfWork, ICenebConversions conversions)
    {
      _unitOfWork = unitOfWork;
      _conversions = conversions;
    }


    public async Task<LocationListModel> LocationToLocationListModel(Location input)
    {
      var createdBy = await _unitOfWork.UnitdataUser.GetSingle(input.CreatedById);
      var updatedBy = await _unitOfWork.UnitdataUser.GetSingle(input.UpdatedById);
      var output = new LocationListModel()
      {
        Id = input.Id,
        isDeleted = input.isDeleted,
        CreatedByFullName = _conversions.FullNameFromuser(createdBy),
        UpdatedByFullName = _conversions.FullNameFromuser(updatedBy),
        CreatedOn = _conversions.DateTimeToString(input.CreatedOn),
        LastUpdatedOn = _conversions.DateTimeToString(input.LastUpdatedOn),
        //Defined

        Description = input.Description,
        Address = input.Address


      };
      return output;
    }

    public async Task<LocationsOverview> LocationToLocationsOverview(Location input)
    {
     
      var allCylinders = await _unitOfWork.Unitcylinder.GetAll();
      var specificCylinder = allCylinders.Where(m => m.CurrentLocationId == input.Id);
      var allCylinderCount = allCylinders.Count();
      var specificCylinderCount = specificCylinder.Count();
      var output = new LocationsOverview()
      {
        LocationAddress = input.Address,
        LocationId = input.Id,
        LocationName = input.Description,
        TotalNumberOfCYlinder = specificCylinderCount
      };
      return output;
    }
  }
}
