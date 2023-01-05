using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.DataAccess.Interface;

namespace TCA.DataAccess.DataContracts
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonsRepository persons { get; }
        IPeoplesSourceAccessRepository peopleSourceAccessRepository { get; }
        void Save();
    }
}
