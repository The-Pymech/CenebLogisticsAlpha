using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Forms
{
  public class VehicleForm
  {
    
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string PlateNumber { get; set; }

    [Required]
    public string VehicleNumber { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public int DriverId { get; set; }
  }
}
