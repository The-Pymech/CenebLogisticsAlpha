using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Crew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.ViewServices
{
  public interface IHistoryCylinderService
  {
    Task<IEnumerable<HistoryCylinderListModel>> GetList();

    Task<bool> AddNew(HistoryCylinder input, string user);
  }
}
