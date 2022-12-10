using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.CenebTask
{
  public class MailCredential
  {

    public string Destination { get; set; }

    public string Subject { get; set; }

    public string Body { get; set; }
  }
}
