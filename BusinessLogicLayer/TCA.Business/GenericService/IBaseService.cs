using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Business.GenericService
{
    public interface IBaseService<T> where T : class, new()
    {
        void Add(T entity);
        void Delete(T entity);
    }
}
