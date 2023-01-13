using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.Entities.Models;

namespace TCA.Business.Interface
{
    public interface IPersonsService 
    {
        IEnumerable<PersonsPositionsHolding> GetListPersons();
    }
}
