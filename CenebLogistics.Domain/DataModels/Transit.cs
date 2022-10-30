using CenebLogistics.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataModels
{
  public class Transit : GeneralDataClass
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public int FromLocation { get; set; }

    [Required]
    public int ToLocation { get; set; }


    //Relationship

    public Vehicle Vehicle { get; set; }
    public int VehicleId { get; set; }



  }
}
