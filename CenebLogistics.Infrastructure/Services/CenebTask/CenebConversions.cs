using CenebLogistics.Application.Services.CenebTask;
using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.DataViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Infrastructure.Services.CenebTask
{
    public class CenebConversions : ICenebConversions
  {
    public UserViewModel DataUserToGetUserViewModel(DataUser user)
    {
      var response = new UserViewModel()
      {
        Id = user.Id,
        DateJoined = user.JoinedDate,
        FirstName = user.FirstName,
        IsActive = user.IsActive,
        LastName = user.LastName,
        MiddleName = user.MiddleName,
        LastLogin = user.LastLogin,
        IsEmailComfirmed = user.EmailConfirmed
        
      };
      return response;
    }

    public string DateTimeToString(DateTime dateTime)
    {
      var stringDate = dateTime.ToString("dddd, dd/MM/yyyy HH:mm");
      return stringDate;
    }

    public string FullNameFromuser(DataUser user)
    {
      var output = $"{user.LastName} {user.FirstName} {user.MiddleName}";
      return output;
    }

    public DateTime GetDateByDaysPast(int daysPast)
    {
      var date = DateTime.Today.AddDays(-daysPast);
      return date;
    }

    public int GetPercentage(int totalNumber, int specificNumber)
    {
      var percentage = (specificNumber / totalNumber) * 100; 
      return percentage;
    }

    public int TotalTrasitPerDate(List<Transit> transits, int dayspast)
    {
      var startCountDate = this.GetDateByDaysPast(dayspast);
      var count = 0;
      foreach (var item in transits)
      {
        if (item.Date > startCountDate)
        {
          count = count + 1;
        }
      }

      return count;

    }
  }
}
