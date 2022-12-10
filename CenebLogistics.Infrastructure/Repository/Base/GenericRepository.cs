using CenebLogistics.Application.Repository.Base;
using CenebLogistics.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Infrastructure.Repository.Base
{
  public class GenericRepository<T, K> : IGenericRepository<T, K> where T : class
  {

    protected CenebDbContext _dbContex;
    protected DbSet<T> _dbSet;
    protected readonly ILogger _logger;


    public GenericRepository(CenebDbContext dbContex, ILogger logger)
    {
      _dbContex = dbContex;
      _dbSet = _dbContex.Set<T>();
      _logger = logger;
    }

    public async Task<T> GetSingle(K id)
    {
      return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
      return await _dbSet.ToListAsync();
    }

    public async Task<bool> Add(T entity)
    {
      await _dbSet.AddAsync(entity);
      return true;
    }

    public bool Delete(T entity)
    {
       
       _dbSet.Remove(entity);
      return true;
    }


    public  bool UpdDate(T entity)
    {
       _dbSet.Update(entity);

      return true;

    }

   

   
  }
}
