﻿using CenebLogistics.Domain.ViewModels.DisplayModels.Forms;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Crew;
using CenebLogistics.Domain.ViewModels.DisplayModels.Pages.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.ViewServices
{
  public interface IVehicleService
  {
    Task<VehicleListViewModel> GetList();

    Task<bool> AddNew(VehicleForm input, string user);

    Task<bool> Update(VehicleForm input, string user);

    Task<bool> Remove(int id, string user);

    Task<bool> Delete(int id, string user);

    Task<VehicleDetailViewModel> Details(int id, string user);


  }
}
