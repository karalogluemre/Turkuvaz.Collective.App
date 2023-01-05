using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.DataAccess.Context;
using TCA.DataAccess.Interface;
using TCA.Entities;
using TCA.Entities.Models;

namespace TCA.DataAccess.Concrete.Repository
{
    public class PersonsRepository : BaseRepository<Persons>, IPersonsRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context; 
        }
    }
}
