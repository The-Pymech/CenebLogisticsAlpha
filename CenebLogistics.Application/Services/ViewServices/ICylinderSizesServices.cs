using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Crew;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.CylinderSizes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.ViewServices
{
  public interface ICylinderSizesServices
  {
    Task<CylinderSizesListViewModel> GetList();

    Task<bool> AddNew(CylinderSizesForm input, string user);

    Task<bool> Update(CylinderSizesForm input, string user);

    Task<bool> Remove(int id, string user);

    Task<bool> Delete(int id, string user);

    Task<CylinderSizesDetailsViewModel> Details(int id, string user);



  }
}
