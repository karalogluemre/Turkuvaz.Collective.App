using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.Entities.Models;

namespace TCA.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Persons> Persons { get; set; }
        public DbSet<PeopleSourceAccess> PeoplesSourceAccess { get; set; }
    }
}
