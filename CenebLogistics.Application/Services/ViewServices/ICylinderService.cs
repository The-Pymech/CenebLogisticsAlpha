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

    public CylinderListViewModel GetListOfCylinder();

  }
}
