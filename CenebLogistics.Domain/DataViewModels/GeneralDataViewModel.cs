using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataViewModels
{
  public class GeneralDataViewModel
  {

    
    public string UpdatedBy { get; set; }
    
    public string CreatedOn { get; set; }
  
    public string UpdatedOn { get; set; }
   
    public string CreatedBy { get; set; }
   
    public bool isDeleted { get; set; }
  }
}
