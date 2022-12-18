using CenebLogistics.Application.Repository.Base;
using CenebLogistics.Application.Services.CenebTask;
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







      return services;
    }
  }
}
