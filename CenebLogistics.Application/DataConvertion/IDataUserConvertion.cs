using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.ViewModels.DisplayModels;
using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.DataConvertion
{
  public interface IDataUserConvertion
  {

    //DataUser DataUserListModelToDataUser(UsersListModel input);

    Task<UsersListModel> DataUserToDataUserListModel(DataUser input);

    LastLoginOverview DataUserToLastLoginOverview(DataUser input);

  }
}
