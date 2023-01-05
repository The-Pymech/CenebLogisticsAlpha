using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Crew;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.CylinderContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.ViewServices
{
  public interface ICylinderContentService
  {
    Task<CylinderContentListViewModel> GetList();

    Task<bool> AddNew(CylinderContentForm input, string user);

    Task<bool> Update(CylinderContentForm input, string user);

    Task<bool> Remove(int id, string user);

    Task<bool> Delete(int id, string user);

    Task<CylinderContentDetailsViewModels> Details(int id, string user);


  }
}
