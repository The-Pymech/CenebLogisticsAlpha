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

    public DateTime CreatedOn { get; set; }

    public DateTime LastUpdatedOn { get; set; }

    public int CreatedById { get; set; }

    public bool isDeleted { get; set; }
  }
}
