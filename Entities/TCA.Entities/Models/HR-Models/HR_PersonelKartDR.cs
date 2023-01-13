using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models.HR_Models
{
    public class HR_PersonelKartDR : BaseEntity
    {
        public int SicilNo { get; set; }
        public string KizlikSoyadi { get; set; }
        public string Adres { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
        public List<HR_Egitim> EGITIM { get; set; }
        public string AskerTerTah { get; set; }
        public string MuafAciklama { get; set; }
        public string WDART { get; set; }
        public string AskerDurum { get; set; }
        public List<HR_KursSeminer> KURS_SEMINER { get; set; }
        public List<HR_Sertifika> SERTIFIKA { get; set; }
        public string Mail { get; set; }
        public string MedeniDurum { get; set; }
        public string AcilDurumTel { get; set; }
        public string Cinsiyet { get; set; }
        public string CepTelNo { get; set; }
    }
}
