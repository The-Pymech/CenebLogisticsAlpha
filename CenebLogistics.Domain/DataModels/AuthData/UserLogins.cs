using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataModels.AuthData
{
  public class DataUserLogins
  {
    public int Id { get; set; }

    public DateTime LoginTime { get; set; }


    //Relationship
    public User User { get; set; }

    public int UserId { get; set; }

  }
}
