using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Pages
{
  public class DashbordViewModel
  {
    public string LastTransitDate { get; set; }

    public int TotalCylinderNumber { get; set; }

    public int TotalActiveVehicles { get; set; }

    public int TotalActiveStaff { get; set; }



    public IEnumerable<CylinderContentOverview> CylinderContents { get; set; }

    public IEnumerable<CylinderSizesOverview> CylinderSizes { get; set; }
    public IEnumerable<CylinderTypeOverVIew> CylinderTypes { get; set; }
    public IEnumerable<CylinderVersionOverview> CylinderVersions { get; set; }
    public IEnumerable<LastLoginOverview> LastLogins { get; set; }
    public IEnumerable<StaffOverview> StaffOverviews { get; set; }
    public IEnumerable<TransitOverview> Transits { get; set; }
    public IEnumerable<VehicleOverview> VehicleOverviews { get; set; }
    public IEnumerable<LocationsOverview> Locations { get; set; }


  }
}
