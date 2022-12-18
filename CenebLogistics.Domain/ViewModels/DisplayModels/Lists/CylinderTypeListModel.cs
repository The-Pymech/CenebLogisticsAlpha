using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Lists
{
  public class CylinderTypeListModel : GeneralDataClassViewmodel
  {
   
    public int Id { get; set; }


    
    public string Name { get; set; }
  }
}
