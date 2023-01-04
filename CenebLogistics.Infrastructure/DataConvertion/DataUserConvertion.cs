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
  public class DataUserConvertion : IDataUserConvertion
  {
    private IUnitOfWork _unitOfWork;
    private ICenebConversions _conversions;
    public DataUserConvertion(IUnitOfWork unitOfWork, ICenebConversions conversions)
    {
      _unitOfWork = unitOfWork;
      _conversions = conversions;
    }
    public async Task<UsersListModel> DataUserToDataUserListModel(DataUser input)
    {
      var output = new UsersListModel()
      {
        Id = input.Id,
        JoinedDate = _conversions.DateTimeToString(input.JoinedDate),
        EmailAddress = input.Email,
        FirstName = input.FirstName,
        IsActive = input.IsActive,
        LastLogin = _conversions.DateTimeToString(input.LastLogin),
        LastName = input.LastName,
        MiddleName = input.MiddleName,
        PhoneNumber = input.PhoneNumber
        
      };

      return output;
    }

    public LastLoginOverview DataUserToLastLoginOverview(DataUser input)
    {
      var output = new LastLoginOverview()
      {
        LastOnline = _conversions.DateTimeToString(input.LastLogin),
        UserFullName = _conversions.FullNameFromuser(input),
        UserId = input.Id
      };

      return output;
    }
  }
}
