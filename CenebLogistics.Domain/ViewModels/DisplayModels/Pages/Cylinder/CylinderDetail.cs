using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Cylinder
{
  public class CylinderDetail
  {

    public CylinderListModel Cylinder { get; set; }


    public IEnumerable<HistoryCylinderListModel> CylinderHistory { get; set; }

  }
}
