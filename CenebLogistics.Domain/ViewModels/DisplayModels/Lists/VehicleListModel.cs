using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Lists
{
  public class VehicleListModel : GeneralDataClassViewmodel
  {
   
    public int Id { get; set; }

   
    public string Name { get; set; }

   
    public string PlateNumber { get; set; }

   
    public string VehicleNumber { get; set; }

    
    public string Description { get; set; }

   
    public int DriverId { get; set; }

  }
}
