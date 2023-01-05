using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Business.GenericService
{
    public interface IHttpGenericService<T> where T:class,new()
    {
        Task<List<T>> GetAllModel(string userName,string password);
    }
}
