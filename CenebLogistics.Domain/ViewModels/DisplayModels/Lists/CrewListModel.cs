using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Lists
{
  public class CrewListModel : GeneralDataClassViewmodel
  {

    public int Id { get; set; }

    public string TransaitDescription { get; set; }

    public string CrewMemberName { get; set; }


    public int TransitId { get; set; }

    public int StaffId { get; set; }

  }
}
