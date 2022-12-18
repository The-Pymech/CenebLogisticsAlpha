using CenebLogistics.Domain.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Forms
{
  public class CylinderForm
  {

    public int Id { get; set; }


    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }


    [Required]
    public int CurrentLocationId { get; set; }
    //Relationships

    [Required]
    public int CylinderContentId { get; set; }




    [Required]
    public int CylinderSizeId { get; set; }




    [Required]
    public int CylinderTypeId { get; set; }



    [Required]
    public int CylinderVersionId { get; set; }



  }
}
