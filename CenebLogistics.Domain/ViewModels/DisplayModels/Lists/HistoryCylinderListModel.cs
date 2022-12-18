using CenebLogistics.Domain.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Lists
{
  public class HistoryCylinderListModel : GeneralDataClassViewmodel
  {
   
    public int Id { get; set; }

    
    public int CylinderId { get; set; }




   
    public string Name { get; set; }


    
    public string Description { get; set; }


    //Relationships

    public string CylinderContent { get; set; }

   
    public int CylinderContentId { get; set; }


    public string CylinderSize { get; set; }

  
    public int CylinderSizeId { get; set; }

    public string CylinderType { get; set; }
    

    public int CylinderTypeId { get; set; }

    public string CylinderVersion { get; set; }

    
    public int CylinderVersionId { get; set; }
  }
}
