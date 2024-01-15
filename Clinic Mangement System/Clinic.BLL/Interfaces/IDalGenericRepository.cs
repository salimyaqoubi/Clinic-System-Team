using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.BLL.Interfaces
{
    public interface IDalGenericRepository<T> 
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        // 
        int Create(T item);
        int Update(T item);
        int Delete(T item);
    }
}
