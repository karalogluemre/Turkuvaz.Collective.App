using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.Entities;

namespace TCA.DataAccess.Interface
{
    public interface IBaseRepository<T> where T : class, new()
    {
        List<T> GetList();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
