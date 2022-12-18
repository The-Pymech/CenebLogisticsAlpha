using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels
{
  public class TransitOverview
  {
    public int TransitId { get; set; }
    public string Description { get; set; }

    public int VehicleId { get; set; }

    public string VehicleName { get; set; }

    public string Driver { get; set; }

    public int NumberOfCrewPersonel { get; set; }

    public string From { get; set; }

    public string To { get; set; }

    public string Date { get; set; }
  }
}
