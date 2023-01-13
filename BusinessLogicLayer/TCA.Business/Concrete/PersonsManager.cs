using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.Business.Interface;
using TCA.DataAccess.Concrete;
using TCA.DataAccess.Concrete.Repository;
using TCA.DataAccess.DataContracts;
using TCA.DataAccess.Interface;
using TCA.Entities.Models;

namespace TCA.Business.Concrete
{
    public class PersonsManager : IPersonsService
    {
        private IUnitOfWork _unitOfWork;
        public PersonsManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<PersonsPositionsHolding> GetListPersons()
        {
            return _unitOfWork.persons.GetList();
        }
    }
}
