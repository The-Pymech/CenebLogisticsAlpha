using CenebLogistics.Application.DataConvertion;
using CenebLogistics.Application.Repository.Base;
using CenebLogistics.Application.Services.CenebTask;
using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Infrastructure.DataConvertion
{
  public class CylinderConvertion : ICylinderConvertion
  {
    private IUnitOfWork _unitOfWork;
    private ICenebConversions _conversions;
    public CylinderConvertion(IUnitOfWork unitOfWork, ICenebConversions conversions)
    {
      _unitOfWork = unitOfWork;
      _conversions = conversions;
    }

    public async Task<CylinderListModel> CylinderToCylinderListModel(Cylinder input)
    {
      var createdBy = await _unitOfWork.UnitdataUser.GetSingle(input.CreatedById);
      var updatedBy = await _unitOfWork.UnitdataUser.GetSingle(input.UpdatedById);
      var location = await _unitOfWork.Unitlocation.GetSingle(input.CurrentLocationId);
      var cylinderVersion = await _unitOfWork.UnitcylinderVersion.GetSingle(input.CylinderVersionId);
      var cylinderContent = await _unitOfWork.UnitcylinderContent.GetSingle(input.CylinderContentId);
      var cylindersize = await _unitOfWork.UnitcylinderSize.GetSingle(input.CylinderSizeId);
      var cylinderType = await _unitOfWork.UnitcylinderType.GetSingle(input.CylinderTypeId);

      var output = new CylinderListModel()
      {
        Id = input.Id,
        isDeleted = input.isDeleted,
        CreatedByFullName = _conversions.FullNameFromuser(createdBy),
        UpdatedByFullName = _conversions.FullNameFromuser(updatedBy),
        CreatedOn = _conversions.DateTimeToString(input.CreatedOn),
        LastUpdatedOn = _conversions.DateTimeToString(input.LastUpdatedOn),
        Description = input.Description,
        CurrentLocationId = input.CurrentLocationId,
        CurrentLocationName = location.Address,
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

    public async Task<Cylinder> FormToData(CylinderForm input, string user)
    {
      var databaseUser = await _unitOfWork.UnitdataUser.GetSingle(user);
      var output = new Cylinder()
      {
        Description = input.Description,
        isDeleted = false,
        Id = input.Id,
        UpdatedById = databaseUser.Id,
        LastUpdatedOn = DateTime.Now,
        CurrentLocationId = input.CurrentLocationId,
        CylinderContentId = input.CylinderContentId,
        CylinderSizeId = input.CylinderSizeId,
        CylinderTypeId = input.CylinderTypeId,
        Name = input.Name,
        CylinderVersionId = input.CylinderVersionId,
      };
      return output;
    }

    public async Task<CylinderForm> GetFormData(int Id)
    {
      var input = await _unitOfWork.Unitcylinder.GetSingle(Id);
      var output = new CylinderForm()
      {
        Id = Id,
        Description = input.Description,
        CurrentLocationId = input.CurrentLocationId,
        CylinderContentId = input.CylinderContentId,
        CylinderSizeId = input.CylinderSizeId,
        CylinderTypeId = input.CylinderTypeId,
        CylinderVersionId = input.CylinderVersionId,
        Name = input.Name
      };
      return output;
    }
  }
}
