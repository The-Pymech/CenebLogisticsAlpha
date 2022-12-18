using CenebLogistics.Domain.DataViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.ViewServices
{
    public interface IDataUserService
  {

    Task UserAccess(string userId);

    Task<UserViewModel> GetUserData(string userId);

    Task UpdateLastOnline(string userId);

    Task<bool> IsUserActive(string userId);

  }
}
