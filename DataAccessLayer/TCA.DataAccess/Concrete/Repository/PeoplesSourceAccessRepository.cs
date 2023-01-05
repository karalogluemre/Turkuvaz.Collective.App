﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.DataAccess.Context;
using TCA.DataAccess.Interface;
using TCA.Entities.Models;

namespace TCA.DataAccess.Concrete.Repository
{
    public class PeoplesSourceAccessRepository : BaseRepository<PeopleSourceAccess>, IPeoplesSourceAccessRepository
    {
        public ApplicationDbContext _context;
        public PeoplesSourceAccessRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
