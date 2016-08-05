using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        void Delete(int id);
        void Update(T entity);
        T GetById(int id);
    }
}
