using CenebLogistics.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataModels
{
  public class CylinderType : GeneralDataClass
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } 

  }
}
