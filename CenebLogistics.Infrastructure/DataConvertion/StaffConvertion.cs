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


  public class StaffConvertion : IStaffConvertion
  {



    private IUnitOfWork _unitOfWork;
    private ICenebConversions _conversions;
    public StaffConvertion(IUnitOfWork unitOfWork, ICenebConversions conversions)
    {
      _unitOfWork = unitOfWork;
      _conversions = conversions;
    }


    public async Task<StaffListModel> StaffToStaffListModel(Staff input)
    {

      var createdBy = await _unitOfWork.UnitdataUser.GetSingle(input.CreatedById);
      var updatedBy = await _unitOfWork.UnitdataUser.GetSingle(input.UpdatedById);


      var output = new StaffListModel()
      {
        Id = input.Id,
        isDeleted = input.isDeleted,
        CreatedByFullName = _conversions.FullNameFromuser(createdBy),
        UpdatedByFullName = _conversions.FullNameFromuser(updatedBy),
        CreatedOn = _conversions.DateTimeToString(input.CreatedOn),
        LastUpdatedOn = _conversions.DateTimeToString(input.LastUpdatedOn),
        FullName = input.FullName,
        Description = input.Description,
        isActive = input.isActive
       
        
      };
      return output;
    }




    public async Task<StaffOverview> StaffToStaffOverview(Staff input)
    {
      var crew = await _unitOfWork.UnitCrew.GetAll();
      var totalCrewMovements = crew.Where(m => m.StaffId == input.Id);
      var transits = new List<Transit>();
      foreach (var item in totalCrewMovements)
      {
        var transit = _unitOfWork.Unittransit.GetSingle(item.TransitId).Result;
        transits.Add(transit);
      }
      var uniqueTransits = transits.GroupBy(i => i.Id).Select(g => g.FirstOrDefault()).ToList();



      var output = new StaffOverview()
      {
        FullName = input.FullName,
        OneDayTripCount = _conversions.TotalTrasitPerDate(uniqueTransits, 1).ToString(),
        SevennDaysTripCount = _conversions.TotalTrasitPerDate(uniqueTransits, 7),
        OneMonthTripCOunt = _conversions.TotalTrasitPerDate(uniqueTransits, 30),
        OneYearTripCount = _conversions.TotalTrasitPerDate(uniqueTransits, 365),
        SixMonthsTripCount = _conversions.TotalTrasitPerDate(uniqueTransits,182),
        ThreeMonthsTripCount = _conversions.TotalTrasitPerDate(uniqueTransits, 91),
        StaffId = input.Id,

      };
      return output;
    }
  }
}
