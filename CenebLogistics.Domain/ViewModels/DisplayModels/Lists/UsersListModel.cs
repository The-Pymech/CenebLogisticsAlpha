using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Lists
{
  public class UsersListModel
  {

    public string Id { get; set; }

    public string EmailAddress { get; set; }


    public string PhoneNumber { get; set; }

    public string FirstName { get; set; }

  
    public string MiddleName { get; set; }

   
    public string LastName { get; set; }


    
    public string LastLogin { get; set; }


   
    public string JoinedDate { get; set; }

    public bool IsActive { get; set; }
  }
}
