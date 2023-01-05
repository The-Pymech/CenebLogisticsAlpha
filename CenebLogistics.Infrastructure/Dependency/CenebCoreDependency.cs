using CenebLogistics.Application.DataConvertion;
using CenebLogistics.Application.Repository.Base;
using CenebLogistics.Application.Services.CenebTask;
using CenebLogistics.Infrastructure.DataConvertion;
using CenebLogistics.Infrastructure.Repository.Base;
using CenebLogistics.Infrastructure.Services.CenebTask;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Infrastructure.Dependency
{
  public static class CenebCoreDependency
  {

    public static IServiceCollection ImplementCenebCoreDependency
      (this IServiceCollection services)
    {


      services.AddScoped<IUnitOfWork, UnitOfWork>();
      services.AddScoped<IEmailService, EmailService>();
      services.AddTransient<ICenebConversions, CenebConversions>();


      //Convertions
      services.AddTransient<ICrewConvertion, CrewConvertion> ();
      services.AddTransient <ICylinderContentConvertion, CylinderContentConvertion> ();
      services.AddTransient <ICylinderConvertion, CylinderConvertion> ();
      services.AddTransient <ICylinderSizesConvertion, CylinderSizesConvertion> ();
      services.AddTransient <ICylinderTypeConvertion, CylinderTypeConvertion> ();
      services.AddTransient <ICylinderVersionConvertion, CylinderVersionConvertion> ();
      services.AddTransient <IDataUserConvertion, DataUserConvertion> ();
      services.AddTransient <IHistoryCylinderConvertion, HistoryCylinderConvertion> ();
      services.AddTransient <ILocationConvertion, LocationConvertion> ();
      services.AddTransient <IStaffConvertion, StaffConvertion> ();
      services.AddTransient <ITransitConvertion, TransitConvertion> ();
      services.AddTransient <IVehicleConvertion, VehicleConvertion> ();





      return services;
    }
  }
}
