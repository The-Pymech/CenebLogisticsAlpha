using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.ViewModels.DisplayModels;
using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.DataConvertion
{
  public interface ICylinderSizesConvertion
  {
    //CylinderSize CylinderSizeListModelToCylinderSizes(CylinderListModel input);

    Task<CylinderSizeListModel> CylinderSizesToCylinderSizeListModel(CylinderSize input);

    CylinderSizesOverview CylinderSizeToCylinderSizesOverview(CylinderSize input);


  }
}
