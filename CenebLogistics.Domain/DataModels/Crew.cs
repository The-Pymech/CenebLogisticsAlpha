using CenebLogistics.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataModels
{
  public class Crew : GeneralDataClass
  {
    [Key]
    public int Id { get; set; }


    //Relationships
    public Transit Transit { get; set; }

    [Required]
    public int TransitId { get; set; }

    public Staff Staff { get; set; }

    [Required]
    public string StaffId { get; set; }
   
  }
}

