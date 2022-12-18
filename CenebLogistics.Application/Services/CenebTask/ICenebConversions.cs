using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.DataViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.CenebTask
{
    public  interface ICenebConversions
  {

    UserViewModel DataUserToGetUserViewModel(DataUser user);

    string DateTimeToString(DateTime dateTime);
  }
}
