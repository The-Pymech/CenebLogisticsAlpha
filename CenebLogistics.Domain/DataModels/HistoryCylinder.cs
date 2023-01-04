using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataModels
{
  public class HistoryCylinder
  {


    [Key]
    public int Id { get; set; }

    [Required]
    public int CylinderId { get; set; }




    [Required]
    public string Name { get; set; }


    [Required]
    public string Description { get; set; }


    //Relationships

    public CylinderContent CylinderContent { get; set; }

    [Required]
    public int CylinderContentId { get; set; }


    public CylinderSize CylinderSize { get; set; }

    [Required]
    public int CylinderSizeId { get; set; }

    public CylinderType CylinderType { get; set; }
    [Required]
    public int CylinderTypeId { get; set; }

    public CylinderVersion CylinderVersion { get; set; }

    [Required]
    public int CylinderVersionId { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime UpdatedOn { get; set; }

 
    public Location CurrentLocation { get; set; }
    public int CurrentLocationId { get; set; }

  }
}
