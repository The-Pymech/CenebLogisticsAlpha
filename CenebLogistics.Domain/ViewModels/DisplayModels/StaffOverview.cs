using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels
{
  public class StaffOverview
  {
    public string StaffId { get; set; }

    public string FullName { get; set; }

    public int SevennDaysTripCount { get; set; }

    public string OneDayTripCount { get; set; }


    public int OneMonthTripCOunt { get; set; }

    public int ThreeMonthsTripCount { get; set; }

    public int SixMonthsTripCount { get; set; }

    public int OneYearTripCount { get; set; }

  }
}
