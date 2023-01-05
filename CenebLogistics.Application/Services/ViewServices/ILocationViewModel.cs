using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Crew;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.ViewServices
{
  public interface ILocationViewModel
  {

    Task<LocationListViewModel> GetList();

    Task<bool> AddNew(LocationForm input, string user);

    Task<bool> Update(LocationForm input, string user);

    Task<bool> Remove(int id, string user);

    Task<bool> Delete(int id, string user);

    Task<LocationDetailsViewModel> Details(int id, string user);



  }
}
