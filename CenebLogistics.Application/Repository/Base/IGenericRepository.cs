using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Repository.Base
{
    public interface IGenericRepository<T, K> where T : class
    {

        Task<T> GetSingle(K id);

        Task<IEnumerable<T>> GetAll();

        bool Delete(T entity);

        Task<bool> Add(T entity);

        bool UpdDate(T entity);

       

        

    }
}
