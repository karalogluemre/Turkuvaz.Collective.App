using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models.HR_Models
{
    public class HR_MobilUsers : BaseEntity
    {
        public int? Sicil { get; set; }
        public string AdSoyad { get; set; }
        public string CepTel { get; set; }
    }
}
