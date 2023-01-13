using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models.HR_Models
{
    public class HR_Lokasyon : BaseEntity
    {
        public int? LokasyonKodu { get; set; }
        public string Tanim { get; set; }
    }
}
