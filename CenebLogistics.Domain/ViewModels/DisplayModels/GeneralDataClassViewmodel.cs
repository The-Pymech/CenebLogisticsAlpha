using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels
{
  public class GeneralDataClassViewmodel
  {

    [Required]
    public string UpdatedByFullName { get; set; }
    [Required]
    public string CreatedOn { get; set; }
    [Required]
    public string LastUpdatedOn { get; set; }
    [Required]
    public string CreatedByFullName { get; set; }
    [Required]
    public bool isDeleted { get; set; }
  }
}
