using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models
{
    public class PersonsCardsDR
    {
        public string PERNR { get; set; }
        public string NAME2 { get; set; }
        public string STRAS { get; set; }
        public string LOCAT { get; set; }
        public string ORT01 { get; set; }
        public List<HR_Egitim> EGITIM { get; set; }
        public string WDERD { get; set; }
        public string ZMUAFNEDEN { get; set; }
        public string WDART { get; set; }
        public string STEXT { get; set; }
        public List<HR_KursSeminer> KURS_SEMINER { get; set; }
        public List<HR_Sertifika> SERTIFIKA { get; set; }
        public string USRID_LONG { get; set; }
        public string FAMST { get; set; }
        public string ACILDRMARAMA { get; set; }
        public string HITAP_BICIMI { get; set; }
        public string CEPNO { get; set; }
    }
}
