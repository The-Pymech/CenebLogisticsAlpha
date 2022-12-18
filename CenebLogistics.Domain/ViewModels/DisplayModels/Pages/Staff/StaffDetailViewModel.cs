using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Staff
{
  public class StaffDetailViewModel
  {

    public StaffOverview Staff { get; set; }

    public IEnumerable<TransitListModel> Transits { get; set; }
  }
}
