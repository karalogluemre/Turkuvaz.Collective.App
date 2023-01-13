using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models.HR_Models
{
    public class HR_OrganizasyonAnahtar : BaseEntity
    {
        public int? AnahtarKodu { get; set; }
        public string Tanim { get; set; }
        public int IKSicil { get; set; }
        public string AdSoyad{ get; set; }
    }
}
