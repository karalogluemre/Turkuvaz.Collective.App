using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models
{
    public class OrganizationLewelHolding
    {
        public string OBJID { get; set; }
        public string ORGTX { get; set; }
        public string UP_OBJID { get; set; }
        public string SEVIYE { get; set; }
        public string SEVIYE_NO { get; set; }
        public string POZISYON { get; set; }
        public string UNVAN { get; set; }

        [JsonProperty("_--31_ONAYCI")]
        public string _31_ONAYCI { get; set; }
        public string MASRAF_YERI { get; set; }
        public string SIRKET_KODU { get; set; }
        public int HIZMET_TURU { get; set; }
        public string ALTHIZMET_TURU { get; set; }
    }
}
