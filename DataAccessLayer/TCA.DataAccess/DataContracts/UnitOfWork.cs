using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TCA.DataAccess.Concrete.Repository;
using TCA.DataAccess.Context;
using TCA.DataAccess.Interface;
using TCA.Entities.Models;
using TCA.Entities.Models.HR_Models;

namespace TCA.DataAccess.DataContracts
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            peopleSourceAccessRepository = new PeoplesSourceAccessRepository(_context);
            persons = new PersonsRepository(_context);
        }
        public IPersonsRepository persons { get; set; }

        public IPeoplesSourceAccessRepository peopleSourceAccessRepository { get; set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
