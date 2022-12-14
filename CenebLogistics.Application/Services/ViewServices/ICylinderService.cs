using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Cylinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.ViewServices
{
  public interface ICylinderService
  {

    Task<CylinderListViewModel> GetListOfCylinder();

    Task<bool> AddNew(CylinderForm input, string user);

    Task<bool> Update(CylinderForm input, string user);

    Task<bool> Remove(int id, string user);

    Task<bool> Delete(int id, string user);

    Task<CylinderDetail> Details(int id, string user);







  }
}
