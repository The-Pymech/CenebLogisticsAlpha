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
  }
}
