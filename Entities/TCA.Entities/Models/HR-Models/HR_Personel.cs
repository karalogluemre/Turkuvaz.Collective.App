using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCA.Entities.Models.HR_Models
{
    public class HR_Personel : BaseEntity
    {
        public int Sicil { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string SirketKodu { get; set; }
        public string SirketTanim { get; set; }
        public string MasrafKodu { get; set; }
        public string MasrafTanim { get; set; }
        public int? OrganizasyonKodu { get; set; }
        public string OrganizasyonTanim { get; set; }
        public string OrganizasyonMasterKodu { get; set; }
        public int? GrupKodu { get; set; }
        public string GrupTanim { get; set; }
        public int? BolumKodu { get; set; }
        public string BolumTanim { get; set; }
        public int? BirimKodu { get; set; }
        public string BirimTanim { get; set; }
        public int? UnvanKodu { get; set; }
        public string UnvanTanim { get; set; }
        public int? GorevKodu { get; set; }
        public string GorevTanim { get; set; }
        public int? OrganizasyonAnahtarKodu { get; set; }
        public string OrganizasyonAnahtarTanim { get; set; }
        public string OrganizasyonAnahtarIK { get; set; }
        public string Domain { get; set; }
        public string Mail { get; set; }
        public string ZzMailBox { get; set; }
        public int? OrganizasyonAmirSicil { get; set; }
        public int? Onayci1 { get; set; }
        public int? Onayci2 { get; set; }
        public int? Onayci3 { get; set; }
        public int? Onayci4 { get; set; }
        public int? Onayci5 { get; set; }
        public string EkOnayci { get; set; }
        public string CepNo { get; set; }
        public string Dahili { get; set; }
        public int? LokasyonKodu { get; set; }
        public string LokasyonTanim { get; set; }
        public int? SozlesmeKodu { get; set; }
        public string SozlesmeTanim { get; set; }
        public string SirketGenelID { get; set; }
        public string SirketGenelTanim { get; set; }
        public string TCKN { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Yaka { get; set; }
        public int? IsAlaniKodu { get; set; }
        public string IsAlaniTanim { get; set; }
        public string PersonelAltAlan { get; set; }
        public int? CalisanGrubu { get; set; }
        public int? CalisanAltGrup { get; set; }
        public string KisiselMail { get; set; }
        public DateTime? Baslangic { get; set; }
        public string Aciklama { get; set; }
        public DateTime? DurumPasif { get; set; }
        public int hr_sap_manuel { get; set; }
        public int? DurumEba { get; set; } = 3;
    }
}
