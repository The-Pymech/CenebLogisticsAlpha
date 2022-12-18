using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Pages.CylinderSizes
{
  public class CylinderSizesListViewModel
  {

    public IEnumerable<CylinderSizeListModel> CylinderSizes { get; set; }
  }
}
