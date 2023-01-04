using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.DataViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.CenebTask
{
  public interface ICenebConversions
  {

    UserViewModel DataUserToGetUserViewModel(DataUser user);

    string DateTimeToString(DateTime dateTime);

    string FullNameFromuser(DataUser user);

    int GetPercentage(int totalNumber, int specificNumber);

    int TotalTrasitPerDate(List<Transit> transits, int dayspast);

    DateTime GetDateByDaysPast(int daysPast);
  }
}
