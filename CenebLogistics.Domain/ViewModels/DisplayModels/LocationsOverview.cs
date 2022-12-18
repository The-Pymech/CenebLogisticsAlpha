using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels
{
  public class LocationsOverview
  {

    public int LocationId { get; set; }

    public string LocationName { get; set; }

    public string LocationAddress { get; set; }

    public int TotalNumberOfCYlinder { get; set; }
  }
}
