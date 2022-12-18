using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Forms
{
  public class CrewForm
  {

    public int Id { get; set; }

    [Required]
    public int TransitId { get; set; }

    [Required]
    public int StaffId { get; set; }

  }

  
}
