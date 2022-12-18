using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Transit
{
  public class TransitListViewModel
  {

    public IEnumerable<TransitListModel> TransitLists { get; set; }
  }
}
