using CenebLogistics.Application.Repository;
using CenebLogistics.Domain.DataModels;
using CenebLogistics.Infrastructure.Data;
using CenebLogistics.Infrastructure.Repository.Base;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Infrastructure.Repository
{
  public class DataUserRepository : GenericRepository<DataUser, string>, IDataUserRepository
  {

    public DataUserRepository(CenebDbContext _dbContext, ILogger _logger) : base(_dbContext, _logger)
    {

    }
  }
}
