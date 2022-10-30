using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.Models
{
  public class GeneralDataClass
  {

    [Required]
    public int UpdatedById { get; set; }
    [Required]
    public DateTime CreatedOn { get; set; }
    [Required]
    public DateTime LastUpdatedOn { get; set; }
    [Required]
    public int CreatedById { get; set; }
    [Required]
    public bool isDeleted { get; set; }
  }
}
