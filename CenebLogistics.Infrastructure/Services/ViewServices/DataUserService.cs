using CenebLogistics.Application.Repository.Base;
using CenebLogistics.Application.Services.CenebTask;
using CenebLogistics.Application.Services.ViewServices;
using CenebLogistics.Domain.DataViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Infrastructure.Services.ViewServices
{
    public class DataUserService : IDataUserService
  {
    private IUnitOfWork _unitOfWork;
    private ICenebConversions _convertions;
    public DataUserService( IUnitOfWork unitOfWork, ICenebConversions cenebConversions)
    {
      _convertions = cenebConversions;
      _unitOfWork = unitOfWork;
    }


    public async Task<UserViewModel> GetUserData(string userId)
    {
      var user = await _unitOfWork.UnitdataUser.GetSingle(userId);
      var output = _convertions.DataUserToGetUserViewModel(user);
      return output;
    }

    public async Task<bool> IsUserActive(string userId)
    {
      bool isActive = false;
      var user = await _unitOfWork.UnitdataUser.GetSingle(userId);
      isActive = user.IsActive;

      return isActive;
    }

    public async Task UpdateLastOnline(string userId)
    {
      var user = await _unitOfWork.UnitdataUser.GetSingle(userId);
      user.LastLogin = DateTime.Now;
      _unitOfWork.UnitdataUser.UpdDate(user);
    }

    public async Task UserAccess(string userId)
    {
      var user = await _unitOfWork.UnitdataUser.GetSingle(userId);
      user.IsActive = !user.IsActive;
      _unitOfWork.UnitdataUser.UpdDate(user);
    }
  }
}
