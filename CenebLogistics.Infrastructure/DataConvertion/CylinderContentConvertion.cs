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
  public class CylinderContentConvertion : ICylinderContentConvertion
  {

    private IUnitOfWork _unitOfWork;
    private ICenebConversions _conversions;
    public CylinderContentConvertion(IUnitOfWork unitOfWork, ICenebConversions conversions)
    {
      _unitOfWork = unitOfWork;
      _conversions = conversions;
    }


    public async Task<CylinderContentListModel> CylinderContentToCylinder(CylinderContent input)
    {
      var createdBy = await _unitOfWork.UnitdataUser.GetSingle(input.CreatedById);
      var updatedBy = await _unitOfWork.UnitdataUser.GetSingle(input.UpdatedById);




      var output = new CylinderContentListModel()
      {
        Id = input.Id,
        isDeleted = input.isDeleted,
        CreatedByFullName = _conversions.FullNameFromuser(createdBy),
        UpdatedByFullName = _conversions.FullNameFromuser(updatedBy),
        CreatedOn = _conversions.DateTimeToString(input.CreatedOn),
        LastUpdatedOn = _conversions.DateTimeToString(input.LastUpdatedOn),
        Name = input.Name





      };
      return output;
    }

    public async Task<CylinderContentOverview> CylinderContentToCylinderContentOverview(CylinderContent input)
    {
      var allCylinders = await  _unitOfWork.Unitcylinder.GetAll();
      var specificCylinder = allCylinders.Where(m => m.CylinderContentId == input.Id);
      var allCylinderCount = allCylinders.Count();
      var specificCylinderCount = specificCylinder.Count();
      var output = new CylinderContentOverview()
      {
        ContentName = input.Name,
        number = specificCylinderCount,
        Percentage = _conversions.GetPercentage(allCylinderCount,specificCylinderCount)
      };
      return output;
    }

  }
}
