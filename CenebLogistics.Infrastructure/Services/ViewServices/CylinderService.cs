using CenebLogistics.Application.DataConvertion;
using CenebLogistics.Application.Repository.Base;
using CenebLogistics.Application.Services.ViewServices;
using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Lists;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Cylinder;
using CenebLogistics.Infrastructure.Migrations;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Infrastructure.Services.ViewServices
{
  public class CylinderService : ICylinderService
  {

    private ILogger _logger;
    private ICylinderConvertion _convertion;
    private IUnitOfWork _unitOfWork;
    public CylinderService(ILogger logger,ICylinderConvertion cylinderConvertion, IUnitOfWork unitOfWork)
    {
      _logger = logger;
      _unitOfWork = unitOfWork;
      _convertion = cylinderConvertion;
       
       
    }


    public async Task<bool> AddNew(CylinderForm input, string user)
    {
      var cylinder = await _convertion.FormToData(input, user);
      cylinder.CreatedOn = DateTime.Now;
      cylinder.CreatedById = user;
      var output =await _unitOfWork.Unitcylinder.Add(cylinder);
      return output;
    }

    public async Task<bool> Delete(int id, string user)
    {
      var input = await _convertion.GetFormData(id);
      var cylinder = await _convertion.FormToData(input, user);
      cylinder.isDeleted = true;
      var output =  _unitOfWork.Unitcylinder.UpdDate(cylinder);
      return output;
    }

    public async Task<CylinderDetail> Details(int id, string user)
    {

      var input = await _unitOfWork.Unitcylinder.GetSingle(id);
      var cylinderdetail = await _convertion.CylinderToCylinderListModel(input);
      var histories = await _unitOfWork.UnithistoryCylinder.GetAll();
      var specificHistory = histories.Where(m => m.CylinderId == id);
      var outputHistories = new List<HistoryCylinderListModel>();
      foreach (var item in specificHistory)
      {

      }

      var output = new CylinderDetail()
      {
        Cylinder = cylinderdetail,

      };

     




     
      return output;
    }

    public Task<CylinderListViewModel> GetListOfCylinder()
    {
      throw new NotImplementedException();
    }

    public async Task<bool> Remove(int id, string user)
    {
      var input = await _convertion.GetFormData(id);
      var cylinder = await _convertion.FormToData(input, user);
      
      var output = _unitOfWork.Unitcylinder.Delete(cylinder);
      return output;
    }

    public async Task<bool> Update(CylinderForm input, string user)
    {
      var cylinder = await _convertion.FormToData(input, user);
      var output = await _unitOfWork.Unitcylinder.Add(cylinder);
      //Add Cylinder History
      var
      return output;
    }
  }
}
