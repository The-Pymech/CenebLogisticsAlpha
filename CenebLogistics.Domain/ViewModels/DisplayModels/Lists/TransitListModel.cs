using CenebLogistics.Domain.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Lists
{
  public class TransitListModel : GeneralDataClassViewmodel
  {
  
    public int Id { get; set; }

   
    public string Description { get; set; }

  
    public string Date { get; set; }

    
    public int FromLocation { get; set; }

    public string ToLocationName { get; set; }

    public int ToLocation { get; set; }


    public string FromLocatomName { get; set; }
    //Relationship

    public string VehicleName { get; set; }
    public int VehicleId { get; set; }
  }
}
