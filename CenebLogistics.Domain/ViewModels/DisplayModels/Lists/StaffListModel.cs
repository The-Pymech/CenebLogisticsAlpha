using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Lists
{
  public class StaffListModel : GeneralDataClassViewmodel
  {
    
    public string Id { get; set; }

    
    public string FullName { get; set; }

    
    public string PhoneNumber { get; set; }

   
    public string Description { get; set; }

    public string isActive { get; set; }
  }
}
