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
  public interface ILocationConvertion
  {
    //Location LocationListModelToLocation(LocationListModel input);

    Task<LocationListModel> LocationToLocationListModel(Location input);



    Task<LocationsOverview> LocationToLocationsOverview(Location input);
  }
}
