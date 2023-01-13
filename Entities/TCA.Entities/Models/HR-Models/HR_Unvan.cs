using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models.HR_Models
{
    public class HR_Unvan : BaseEntity
    {
        public int? UnvanKodu { get; set; }
        public string Tanim { get; set; }
    }
}
