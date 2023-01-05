using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models
{
    public class PeopleSourceAccess : IEntity
    {
        public string MANDT { get; set; }
        public string PERNR { get; set; }
        public string CNAME { get; set; }
        public string VDSK1 { get; set; }
    }
}
