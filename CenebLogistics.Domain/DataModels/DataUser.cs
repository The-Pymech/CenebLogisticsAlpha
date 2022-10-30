using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataModels
{
  public class DataUser
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string MiddleName { get; set; }

    [Required]
    public string LastName { get; set; }


    [Required, EmailAddress]
    public string EmailAddress { get; set; }


    public double PhoneNumber { get; set; }



    [Required]
    public DateTime LastLogin { get; set; }



    [Required]
    public DateTime JoinedDate { get; set; }

    
  }
}
