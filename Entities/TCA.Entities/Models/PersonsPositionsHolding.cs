using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models
{
    public class PersonsPositionsHolding : BaseEntity
    {
        public string OBJID { get; set; }
        public string BEGDA { get; set; }
        public string ENDDA { get; set; }
        public string MC_STEXT { get; set; }
    }
}
