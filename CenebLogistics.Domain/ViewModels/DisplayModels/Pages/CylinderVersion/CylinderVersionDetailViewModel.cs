using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Pages.CylinderVersion
{
  public class CylinderVersionDetailViewModel
  {
    public CylinderVersionOverview CylinderVersion { get; set; }

    public IEnumerable<CylinderListModel> Cylinders { get; set; }
  }
}
