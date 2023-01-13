using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models
{
    public  class HR_Organizasyon : BaseEntity
    {
        public int? OrganizasyonKodu { get; set; }
        public string Tanim { get; set; }
    }
}
