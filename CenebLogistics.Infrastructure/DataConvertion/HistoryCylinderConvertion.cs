using CenebLogistics.Application.DataConvertion;
using CenebLogistics.Application.Repository.Base;
using CenebLogistics.Application.Services.CenebTask;
using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Infrastructure.DataConvertion
{
  public class HistoryCylinderConvertion : IHistoryCylinderConvertion
  {

    private IUnitOfWork _unitOfWork;
    private ICenebConversions _conversions;
    public HistoryCylinderConvertion(IUnitOfWork unitOfWork, ICenebConversions conversions)
    {
      _unitOfWork = unitOfWork;
      _conversions = conversions;
    }
    public async Task<HistoryCylinderListModel> HistoryCylinderToHistoryCylinderListModel(HistoryCylinder input)
    {
     
      var updatedBy = await _unitOfWork.UnitdataUser.GetSingle(input.UpdatedBy);
      var location = await _unitOfWork.Unitlocation.GetSingle(input.CurrentLocationId);
      var cylinderVersion = await _unitOfWork.UnitcylinderVersion.GetSingle(input.CylinderVersionId);
      var cylinderContent = await _unitOfWork.UnitcylinderContent.GetSingle(input.CylinderContentId);
      var cylindersize = await _unitOfWork.UnitcylinderSize.GetSingle(input.CylinderSizeId);
      var cylinderType = await _unitOfWork.UnitcylinderType.GetSingle(input.CylinderTypeId);
      var output = new HistoryCylinderListModel()
      {
        Description = input.Description,
        isDeleted = false,
        UpdatedByFullName = _conversions.FullNameFromuser(updatedBy),
        LastUpdatedOn = _conversions.DateTimeToString(input.UpdatedOn),
        CreatedByFullName = "See Cylinder",
        CreatedOn = "See Cylinder",
        
        LocationId = location.Id,
        LocationAddress = location.Address,
        CylinderVersionId = cylinderVersion.Id,
        CylinderVersion = cylinderVersion.Name,
        CylinderContentId = cylinderContent.Id,
        CylinderContent = cylinderContent.Name,
        CylinderSizeId = cylindersize.Id,
        CylinderSize = cylindersize.Name,
        CylinderType = cylinderType.Name,
        CylinderTypeId = cylinderType.Id,
        Name = input.Name
      };

      return output;
    }
  }
}
