using CenebLogistics.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataModels
{
  public class Cylinder : GeneralDataClass
  {
    [Key]
    public int Id { get; set; }



    [Required]
    public string Name { get; set; }


    [Required]
    public string Description { get; set; }


    [Required]
    public int CurrentLocationId { get; set; }


    //Relationships

    public CylinderContent CylinderContent { get; set; }
    public int CylinderContentId { get; set; }




    public CylinderSize CylinderSize { get; set; }
    public int CylinderSizeId { get; set; }




    public CylinderType CylinderType { get; set; }
    public int CylinderTypeId { get; set; }



    public CylinderVersion CylinderVersion { get; set; }
    public int CylinderVersionId { get; set; }


  


  }
}
