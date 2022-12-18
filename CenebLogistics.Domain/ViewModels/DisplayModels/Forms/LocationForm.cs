using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Forms
{
  public class LocationForm
  {
    
    public int Id { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string Description { get; set; }
  }
}
