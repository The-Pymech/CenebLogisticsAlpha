using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Crew;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.CylinderType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.ViewServices
{
  public interface ICylinderTypeService
  {
    Task<CylinderTypeListViewModel> GetList();

    Task<bool> AddNew(CylinderTypeForm input, string user);

    Task<bool> Update(CylinderTypeForm input, string user);

    Task<bool> Remove(int id, string user);

    Task<bool> Delete(int id, string user);

    Task<CylinderTypeDetailViewModel> Details(int id, string user);
  }
}
