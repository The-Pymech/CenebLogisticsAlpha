using CenebLogistics.Domain.DataViewModels;
using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Crew;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.CylinderVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.ViewServices
{
  public interface ICylinderVersionService
  {

    Task<CylinderVersionListViewModel> GetList();

    Task<bool> AddNew(CylinderVersionForm input, string user);

    Task<bool> Update(CylinderVersionForm input, string user);

    Task<bool> Remove(int id, string user);

    Task<bool> Delete(int id, string user);

    Task<CylinderVersionDetailViewModel> Details(int id, string user);

  }
}
