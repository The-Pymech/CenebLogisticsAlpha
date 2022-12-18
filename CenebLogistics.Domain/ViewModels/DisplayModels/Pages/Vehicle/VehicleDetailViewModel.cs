using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Vehicle
{
  public class VehicleDetailViewModel
  {
    public VehicleOverview Vehicle { get; set; }

    public IEnumerable<TransitListModel> Transits { get; set; }
  }
}
