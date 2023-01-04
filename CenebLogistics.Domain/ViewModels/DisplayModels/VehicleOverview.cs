using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels
{
  public class VehicleOverview
  {
    public int VehileId { get; set; }
    public string VehicleName { get; set; }

    public string DriverName { get; set; }

    public string LastTransitDate { get; set; }
  }
}
