﻿using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Pages.DataUser
{
  public class DataUserDetailViewModel
  {

    public UsersListModel User { get; set; }


    public IEnumerable<HistoryCylinderListModel> HistoryCylinders { get; set; }
  }
}
