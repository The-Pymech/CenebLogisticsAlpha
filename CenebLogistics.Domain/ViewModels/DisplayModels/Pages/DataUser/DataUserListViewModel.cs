using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Pages.DataUser
{
  public class DataUserListViewModel
  {

    public IEnumerable<UsersListModel> Users { get; set; }
  }
}
