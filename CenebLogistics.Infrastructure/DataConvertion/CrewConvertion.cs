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
  public class CrewConvertion : ICrewConvertion
  {

    private IUnitOfWork _unitOfWork;
    private ICenebConversions _conversions;
    public CrewConvertion(IUnitOfWork unitOfWork, ICenebConversions conversions)
    {
      _unitOfWork = unitOfWork;
      _conversions = conversions;
    }

    public async Task<CrewListModel> CrewToCrewListModel(Crew input)
    {
      var transit = await _unitOfWork.Unittransit.GetSingle(input.TransitId);
      var createdBy = await _unitOfWork.UnitdataUser.GetSingle(input.CreatedById);
      var updatedBy = await _unitOfWork.UnitdataUser.GetSingle(input.UpdatedById);
      var crewMember = await _unitOfWork.Unitstaff.GetSingle(input.StaffId);
      var outPut = new CrewListModel()
      {
        isDeleted = input.isDeleted,
        TransaitDescription = transit.Description,
        CreatedByFullName = _conversions.FullNameFromuser(createdBy),
        CreatedOn = _conversions.DateTimeToString(input.CreatedOn),
        CrewMemberName = crewMember.FullName,
        Id = input.Id,
        LastUpdatedOn = _conversions.DateTimeToString(input.LastUpdatedOn),
        StaffId = input.StaffId,
        TransitId = input.TransitId,
        UpdatedByFullName = _conversions.FullNameFromuser(updatedBy)

      };

      return outPut;
    }

  
  }
}
