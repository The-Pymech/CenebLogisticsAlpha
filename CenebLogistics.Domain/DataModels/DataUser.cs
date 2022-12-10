using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataModels
{
  public class DataUser : IdentityUser
  {

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string MiddleName { get; set; }

    [Required]
    public string LastName { get; set; }


    [Required]
    public DateTime LastLogin { get; set; }



    [Required]
    public DateTime JoinedDate { get; set; }

    [Required]
    public bool IsActive { get; set; }



  }
}
