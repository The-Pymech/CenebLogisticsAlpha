using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Transit
{
  public class TransitDetailViewModel
  {
    public TransitOverview Transit { get; set; }

    public LocationListModel Location { get; set; }

    public VehicleListModel Vehicle { get; set; }

    public IEnumerable<StaffListModel> ListOfStaff { get; set; }

    public IEnumerable<CylinderListModel> Cylinders { get; set; }
  }
}
