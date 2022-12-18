using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataViewModels
{
  public class CylinderViewModel : GeneralDataViewModel
  {

    public int Id { get; set; }

  
    public string Name { get; set; }
   
    public string Description { get; set; }

    public string CylinderContent { get; set; }

    public string CylinderSize { get; set; }

    public string CylinderType { get; set; }

    public string CylinderVersion { get; set; }

    public string UpdatedOn { get; set; }

    public string UpdatedBy { get; set; }

    public string CreatedOn { get; set; }

    public string CreatedBy { get; set; }

    


  }
}
