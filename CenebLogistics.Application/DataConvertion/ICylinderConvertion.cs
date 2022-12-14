using CenebLogistics.Domain.DataModels;
using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.DataConvertion
{
  public interface ICylinderConvertion
  {

    //Cylinder CylinderListModelToCylinder(CylinderListModel input); 

    Task<CylinderListModel> CylinderToCylinderListModel(Cylinder input);


    Task<Cylinder> FormToData(CylinderForm input, string user);

    Task<CylinderForm> GetFormData(int Id);
  }
}
